using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Servicios_Eventos_Api_DS4.DAL
{
    public class Db
    {
        private readonly string _cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public SqlConnection Open()
        {
            var cn = new SqlConnection(_cs);
            cn.Open();
            return cn;
        }

        public SqlCommand Cmd(SqlConnection cn, string sp)
        {
            var cmd = new SqlCommand(sp, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
