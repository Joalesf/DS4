using System.Web;
using System.Web.Mvc;

namespace Servicios_Eventos_Api_DS4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
