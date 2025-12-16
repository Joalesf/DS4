using Servicios_Eventos_Api_DS4.DAL;
using System.Web.Mvc;

namespace Servicios_Eventos_Api_DS4.Controllers
{
    public class PagosController : Controller
    {
        private readonly Db _db = new Db();

        public ActionResult Pagar(int id)
        {
            if (Session["UserId"] == null) return RedirectToAction("Login", "Account");
            ViewBag.ReservaId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Pagar(int reservaId, string metodo)
        {
            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Pago_Simulado"))
            {
                cmd.Parameters.AddWithValue("@ReservaId", reservaId);
                cmd.Parameters.AddWithValue("@Metodo", metodo);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("MisReservas", "Servicios");
        }
    }
}
