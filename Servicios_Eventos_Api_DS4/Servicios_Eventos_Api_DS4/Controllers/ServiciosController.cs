using Servicios_Eventos_Api_DS4.DAL;
using Servicios_Eventos_Api_DS4.Models;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace Servicios_Eventos_Api_DS4.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly Db _db = new Db();

        public ActionResult Index()
        {
            if (Session["UserId"] == null)
                return RedirectToAction("Login", "Account");

            var list = new List<Servicio>();

            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Servicios_Listar"))
            using (var da = new System.Data.SqlClient.SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new Servicio
                    {
                        ServicioId = (int)r["ServicioId"],
                        Nombre = r["Nombre"].ToString(),
                        Descripcion = r["Descripcion"].ToString(),
                        Precio = (decimal)r["Precio"]
                    });
                }
            }

            return View(list);
        }

        public ActionResult Reservar(int id)
        {
            if (Session["UserId"] == null)
                return RedirectToAction("Login", "Account");

            ViewBag.ServicioId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Reservar(int servicioId, string titulo, string fechaEvento, string lugar, int cantidad)
        {
            int clienteId = (int)Session["UserId"];
            int eventoId;

            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Evento_Crear"))
            {
                cmd.Parameters.AddWithValue("@Titulo", titulo);
                cmd.Parameters.AddWithValue("@FechaEvento", System.DateTime.Parse(fechaEvento));
                cmd.Parameters.AddWithValue("@Lugar", lugar);
                cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                eventoId = System.Convert.ToInt32(cmd.ExecuteScalar());
            }

            int reservaId;
            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Reserva_Crear"))
            {
                cmd.Parameters.AddWithValue("@EventoId", eventoId);
                cmd.Parameters.AddWithValue("@ServicioId", servicioId);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);

                using (var rd = cmd.ExecuteReader())
                {
                    rd.Read();
                    reservaId = System.Convert.ToInt32(rd["ReservaId"]);
                }
            }

            return RedirectToAction("Pagar", "Pagos", new { id = reservaId });
        }

        public ActionResult MisReservas()
        {
            if (Session["UserId"] == null)
                return RedirectToAction("Login", "Account");

            var list = new List<ReservaVM>();

            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_MisReservas"))
            {
                cmd.Parameters.AddWithValue("@ClienteId", (int)Session["UserId"]);

                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        list.Add(new ReservaVM
                        {
                            ReservaId = (int)rd["ReservaId"],
                            Titulo = rd["Titulo"].ToString(),
                            Servicio = rd["Servicio"].ToString(),
                            Cantidad = (int)rd["Cantidad"],
                            Total = (decimal)rd["Total"],
                            Estado = rd["Estado"].ToString(),
                            FechaReserva = (System.DateTime)rd["FechaReserva"],
                            FechaEvento = (System.DateTime)rd["FechaEvento"]
                        });
                    }
                }
            }

            return View(list);
        }
    }
}
