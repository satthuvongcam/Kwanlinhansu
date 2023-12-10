using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihosonhansu.Connection
{
    internal class Connection
    {
        private static string 
        stringConnection = @"Data Source=DESKTOP-S707CIN;Initial Catalog=qlinhansu2.0;User ID=sa;Password=123asdasd123";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
        
    }
}
