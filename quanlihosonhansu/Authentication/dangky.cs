using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using quanlihosonhansu.Connection;
using System.Data.SqlClient;

namespace quanlihosonhansu.Authentication
{
    public partial class dangky : Form
    {
        SqlConnection conn = Connection.Connection.GetSqlConnection();
        public dangky()
        {
            InitializeComponent();
        }

        private void dangky_Load(object sender, EventArgs e)
        {

        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string rePassword = textBox3.Text;
            if(username == "" || password =="" || rePassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(password != rePassword)
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hashedPassword = HashPassword(password);

                string sql = $"INSERT INTO dbo.nhanvien (email, password) VALUES ('{username}', '{hashedPassword}')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Bạn đã thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn đã thêm người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dangnhap formDangNhap = new dangnhap();

            // Ẩn form đăng ký hiện tại
            this.Close();

            // Hiển thị lại form đăng nhập
            formDangNhap.Show();
        }
    }
}
