using quanlihosonhansu.Admin__duan;
using quanlihosonhansu.Connection;
using System.Data.SqlClient;
using System.Diagnostics;

namespace quanlihosonhansu
{
    public partial class Form1 : Form
    {
        SqlConnection conn = Connection.Connection.GetSqlConnection(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2333 frm = new Form2333();
            this.Hide();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("text changed");
        }
    }
}