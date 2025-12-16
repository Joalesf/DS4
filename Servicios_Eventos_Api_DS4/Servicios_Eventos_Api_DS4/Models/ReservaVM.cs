using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Servicios_Eventos_Api_DS4.Models
{
    public class ReservaVM
    {
        public int ReservaId { get; set; }
        public string Titulo { get; set; }
        public string Servicio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaEvento { get; set; }
    }
}
