using Servicios_Eventos_Api_DS4.DAL;
using Servicios_Eventos_Api_DS4.Models;
using System.Web.Mvc;


namespace Servicios_Eventos_Api_DS4.Controllers
{
    public class AccountController : Controller
    {
        private readonly Db _db = new Db();

        public ActionResult Login() => View();

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            using (var cn = _db.Open())
            using (var cmd = _db.Cmd(cn, "sp_Login"))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read())
                    {
                        ViewBag.Error = "Credenciales incorrectas.";
                        return View();
                    }

                    var u = new Usuario
                    {
                        UsuarioId = (int)rd["UsuarioId"],
                        Nombre = rd["Nombre"].ToString(),
                        Email = rd["Email"].ToString(),
                        Rol = rd["Rol"].ToString()
                    };

                    Session["UserId"] = u.UsuarioId;
                    Session["UserName"] = u.Nombre;
                    Session["Role"] = u.Rol;

                    if (u.Rol == "Admin")
                        return RedirectToAction("Dashboard", "Admin");

                    return RedirectToAction("Index", "Servicios");
                }
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
