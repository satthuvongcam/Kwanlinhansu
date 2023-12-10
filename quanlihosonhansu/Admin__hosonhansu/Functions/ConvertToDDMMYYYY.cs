using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihosonhansu.Admin__hosonhansu.Functions
{
    internal class ConvertToDDMMYYYY
    {
        public static string parseDateTime(DateTime dateTimePicker_Value)
        {
            // Chuyển từ dạng datetime sang dạng string kiểu M/DD/YYYY; mục đích để parse về DB
            string timeString = dateTimePicker_Value.Day + "/" + dateTimePicker_Value.Month + "/" + dateTimePicker_Value.Year;
            return timeString;
        }
    }
}
