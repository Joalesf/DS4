using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Eventos_Api_DS4.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
    }
}