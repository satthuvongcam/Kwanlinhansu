using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanlihosonhansu.Connection;
using System.Diagnostics;

namespace quanlihosonhansu.Admin__hosonhansu.Functions
{
    internal class Getdata
    {
        public static DataTable getData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Connection.Connection.GetSqlConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
