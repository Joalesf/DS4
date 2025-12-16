using Servicios_Eventos_Api_DS4.DAL;
using Servicios_Eventos_Api_DS4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace Servicios_Eventos_Api_DS4.Controllers
{
    public class AdminController : Controller
    {
        private readonly Db _db = new Db();

        private bool IsAdmin() => Session["Role"] != null && Session["Role"].ToString() == "Admin";

        public ActionResult Dashboard()
        {
            if (!IsAdmin()) return RedirectToAction("Login", "Account");
            return View();
        }

        public ActionResult Servicios()
        {
            if (!IsAdmin()) return RedirectToAction("Login", "Account");

            var list = new List<Servicio>();
            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Servicios_ListarAdmin"))
            using (var da = new System.Data.SqlClient.SqlDataAdapter(cmd))
            {
                var dt = new DataTable(); da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new Servicio
                    {
                        ServicioId = (int)r["ServicioId"],
                        Nombre = r["Nombre"].ToString(),
                        Descripcion = r["Descripcion"].ToString(),
                        Precio = (decimal)r["Precio"],
                        Activo = (bool)r["Activo"],
                        ProveedorId = r["ProveedorId"] == DBNull.Value ? (int?)null : (int)r["ProveedorId"]
                    });
                }
            }
            return View(list);
        }

        public ActionResult NuevoServicio()
        {
            if (!IsAdmin()) return RedirectToAction("Login", "Account");
            return View();
        }

        [HttpPost]
        public ActionResult NuevoServicio(string nombre, string descripcion, decimal precio, int? proveedorId, bool activo = true)
        {
            if (!IsAdmin()) return RedirectToAction("Login", "Account");

            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Servicio_Insertar"))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion ?? "");
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@ProveedorId", (object)proveedorId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Activo", activo);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Servicios");
        }

        public ActionResult Reservas()
        {
            if (!IsAdmin()) return RedirectToAction("Login", "Account");

            var dt = new DataTable();
            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Admin_Reservas"))
            using (var da = new System.Data.SqlClient.SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            return View(dt);
        }
    }
}
