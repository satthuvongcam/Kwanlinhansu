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
<<<<<<< HEAD
        private static string 
        stringConnection = @"Data Source=pc;Initial Catalog=kwanlinhansu;Integrated Security=True";
=======
        private static string stringConnection = @"Data Source=MSI;Initial Catalog=QLNhanSu;Integrated Security=True;";
>>>>>>> ec84e2265a742a364e8f0f37ac516935dfe3b733
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
        
    }
}
