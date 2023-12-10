using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihosonhansu.Admin__hosonhansu.Functions
{
    internal class assignCombo
    {
        static DataTable ConvertArrayToDataTable(string[,] array)
        {
            DataTable dataTable = new DataTable();

            // Create columns
            for (int colIndex = 0; colIndex < array.GetLength(1); colIndex++)
            {
                dataTable.Columns.Add($"Column{colIndex + 1}", typeof(string));
            }

            // Populate rows
            for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
            {
                DataRow row = dataTable.NewRow();
                for (int colIndex = 0; colIndex < array.GetLength(1); colIndex++)
                {
                    row[colIndex] = array[rowIndex, colIndex];
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public static void assigningComboDB
            (ComboBox cbo, string tenbang, string truonghienthi, string truongma)
        {
            string sql = "Select " + truongma + "," + truonghienthi + " from " + tenbang + " ";
            cbo.DataSource = Getdata.getData(sql);
            cbo.DisplayMember = truonghienthi;
            cbo.ValueMember = truongma;
            cbo.SelectedValue = 0;
        }

        public static void assigningComboCustom(ComboBox cbo, string[,] dataArray)
        {
            DataTable dt = ConvertArrayToDataTable(dataArray);
            cbo.DataSource = dt;
            cbo.DisplayMember = dt.Columns[1].ColumnName;
            cbo.ValueMember = dt.Columns[0].ColumnName;
            cbo.SelectedValue = -1;
        }
    }
}
