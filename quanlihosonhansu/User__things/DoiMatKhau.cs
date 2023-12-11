using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlihosonhansu.User__things
{
    public partial class DoiMatKhau : Form
    {
        public int loginID { get; set; }
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        // nhảy code của thằng linh 
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        // kiểm tra xem control.text hiện tại có giống với database không
        private bool CheckOldPassword(Control control)
        {
            using (SqlConnection connection = Connection.Connection.GetSqlConnection())
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM nhanvien WHERE password = @controlTxt";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // chỉnh lại để so được với pass đã mã hóa trong database
                    command.Parameters.AddWithValue("@controlTxt", HashPassword(control.Text));

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        // 1 đống field validation trước khi load vào database
        private void doiMatKhauButton_Click(object sender, EventArgs e)
        {
            string password = matKhauMoiTextBox.Text;
            if (string.IsNullOrWhiteSpace(matKhauCuTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhauMoiTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhauMoiTextBox.Text.Length < 8 || matKhauMoiTextBox.Text.Length > 16)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 8 kí tự và nhiều nhất 16 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckOldPassword(matKhauCuTextBox) == false)
            {
                MessageBox.Show("Sai mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckOldPassword(matKhauMoiTextBox))
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nhapLaiTextBox.Text != matKhauMoiTextBox.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không giống nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhauMoiTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu mới không được chứa khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = Connection.Connection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    string hashedPassword = HashPassword(password);
                    string query = $"UPDATE nhanvien SET password = @password WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@ID", loginID);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đổi mật khẩu thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    this.Close();
                }
            }
        }

        private void nhapLaiTextBox_TextChanged(object sender, EventArgs e)
        {
            if(nhapLaiTextBox.Text != matKhauMoiTextBox.Text)
            {
                reminderLable.Visible = true;
            }
            else
            {
                reminderLable.Visible = false;
            }
        }
    }
}
