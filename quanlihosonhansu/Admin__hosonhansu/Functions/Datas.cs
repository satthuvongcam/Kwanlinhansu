using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihosonhansu.Admin__hosonhansu.Functions
{
    internal class Datas
    {
        public static string[,] getGender()
        {
            string[,] dataArray = {
            { "0", "male" },
            { "1", "female" },
            { "2", "other" }
        };
            return dataArray;
        }

        public static string[,] getStaffStatus()
        {
            string[,] dataArray = {
            { "0", "true" },
            { "1", "false" },
        };
            return dataArray;
        }

        public static string[,] getWorkStatus()
        {
            string[,] dataArray = {
            { "0", "Is not working" },
            { "1", "Is working" },
            { "2", "Is having a break" },
        };
            return dataArray;
        }
    }
}
