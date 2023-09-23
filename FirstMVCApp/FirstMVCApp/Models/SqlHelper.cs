
using Microsoft.Data.SqlClient;

namespace FirstMVCApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()  //Factory method
        {
            var connString = @"server=200411LTP2858\SQLEXPRESS;database=Testdb;
                               integrated security=true;Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;   
        }
    }
}
