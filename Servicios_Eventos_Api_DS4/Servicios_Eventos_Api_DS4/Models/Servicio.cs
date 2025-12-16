using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Eventos_Api_DS4.Models
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
        public int? ProveedorId { get; set; }
    }
}