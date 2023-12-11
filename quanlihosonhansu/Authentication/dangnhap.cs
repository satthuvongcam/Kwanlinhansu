using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using quanlihosonhansu.Connection;
using quanlihosonhansu.User__things;

namespace quanlihosonhansu.Authentication
{
    public partial class dangnhap : Form
    {
        public int loginID;
        SqlConnection conn = Connection.Connection.GetSqlConnection();
        public dangnhap()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void OpenUserForm()
        {
            UserForm formUser = new UserForm();
            //LinhDz: ID người hiện tại đang đăng nhập
            formUser.loginID = loginID;

            // Đóng form hiện tại
            this.Hide();

            // Hiển thị form mới
            formUser.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "" || password == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hashedPassword = HashPassword(password);

                string sql = $"SELECT * FROM dbo.nhanvien WHERE email = '{username}' AND password = '{hashedPassword}'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    object isStaffObj = reader["is_staff"];
                    loginID = Convert.ToInt32(reader["id"]);

                    if (isStaffObj != DBNull.Value)
                    {
                        bool isStaff = Convert.ToBoolean(isStaffObj);

                        if (isStaff)
                        {
                            // Đăng nhập thành công cho admin
                            MessageBox.Show("Đăng nhập thành công! Chào mừng Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            OpenUserForm();
                        }
                    }
                    else
                    {
                        OpenUserForm();
                    }
                }
                else
                {
                    // Đăng nhập thất bại
                    MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            dangky formDangKy = new dangky();

            // Đóng form hiện tại
            this.Hide();

            // Hiển thị form mới
            formDangKy.Show(); 
        }
    }
}
