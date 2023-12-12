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
        stringConnection = @"Data Source=MSI;Initial Catalog=QLNhanSu;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
        
    }
}
