using quanlihosonhansu.Authentication;
using quanlihosonhansu.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanlihosonhansu.User__things
{
    public partial class UserForm : Form
    {
        public int loginID { get; set; }
        //flag check xem là đang đăng xuất hay thoát
        private bool logoutFlag = false;
        // biến dạng cho trạng thái đầu tiên (nút reset sẽ reset về các biến này)
        string originalEmail = "";
        string originalSDT = "";
        string originalDiaChi = "";
        public UserForm()
        {
            InitializeComponent();
            InitializeButton();
            InitializeComboBox();
        }
        // cài đặt cho đống button không còn border
        private void InitializeButton()
        {
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.FlatAppearance.BorderSize = 0;
        }
        // kiểm tra dữ liệu có khớp với dự liễu lần gân đây nhất không
        private bool DataChanged(Control control, string originalText)
        {
            if (control.Text != originalText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //detach event để tránh bắt nhầm
        private void txtBoxEventDetach()
        {
            emailTextBox.TextChanged -= txtBoxChanged;
            soDienThoaiTextBox.TextChanged -= txtBoxChanged;
            diaChiTextBox.TextChanged -= txtBoxChanged;
        }
        //retach event
        private void txtBoxEventRetach()
        {
            emailTextBox.TextChanged += txtBoxChanged;
            soDienThoaiTextBox.TextChanged += txtBoxChanged;
            diaChiTextBox.TextChanged += txtBoxChanged;
        }
        //update lại dữ liệu gần đây nhất
        private void updateOGData()
        {
            originalEmail = emailTextBox.Text.ToString();
            originalSDT = soDienThoaiTextBox.Text.ToString();
            originalDiaChi = diaChiTextBox.Text.ToString();
        }
        // load data vào datagridview
        private void InitializeDataGridView(int ID)
        {
            using (SqlConnection connection = Connection.Connection.GetSqlConnection())
            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = "SELECT d.id, d.ten, d.mo_ta FROM duan d JOIN nhanvien_duan nd ON d.id = nd.duan_id JOIN nhanvien nv ON nv.id = nd.nhanvien_id WHERE nv.id = @ID";
                    command.Parameters.AddWithValue("@Id", ID);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    int desiredRowCount = 4;
                    int currentRowCount = ds.Tables[0].Rows.Count;
                    int rowsToAdd = desiredRowCount - currentRowCount;

                    // Thêm các hàng trống với dữ liệu giả mạo
                    for (int i = 0; i < rowsToAdd; i++)
                    {
                        ds.Tables[0].Rows.Add();
                    }

                    projectDataGridView.DataSource = ds.Tables[0].DefaultView;

                    projectDataGridView.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    projectDataGridView.Columns["ten"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    projectDataGridView.Columns["mo_ta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    projectDataGridView.Columns["id"].HeaderText = "ID";
                    projectDataGridView.Columns["ten"].HeaderText = "TÊN DỰ ÁN";
                    projectDataGridView.Columns["mo_ta"].HeaderText = "MÔ TẢ";

                    projectDataGridView.Columns["id"].Width = 50; // Độ dài 50 pixels
                    projectDataGridView.Columns["ten"].Width = 150; // Độ dài 150 pixels
                    projectDataGridView.Columns["mo_ta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động điều chỉnh độ rộng để lấp đầy DataGridView

                    projectDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(projectDataGridView_RowPrePaint);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //load data từ database vào form
        private void InitializeData(int ID)
        {
            using (SqlConnection connection = Connection.Connection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command;
                SqlDataReader dataReader;

                string query = "SELECT n.*, p.ten AS ten_phong_ban, cv.ten AS ten_chuc_vu, l.* " +
                               "FROM nhanvien n " +
                               "JOIN phongban p ON n.phong_ban_id = p.ID " +
                               "JOIN chucvu cv ON n.chuc_vu_id = cv.ID " +
                               "JOIN luong l ON n.id = l.nhan_vien_id " +
                               "WHERE n.id = @TargetID";

                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TargetID", ID);

                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    try
                    {

                        hoTenTextBox.Text = dataReader["ho_ten"].ToString();
                        ngaySinhTextBox.Text = dataReader["ngay_sinh"].ToString();
                        emailTextBox.Text = dataReader["email"].ToString();
                        soDienThoaiTextBox.Text = dataReader["password"].ToString();
                        diaChiTextBox.Text = dataReader["dia_chi"].ToString();
                        chucVuTextBox.Text = dataReader["ten_chuc_vu"].ToString();
                        phongBanTextBox.Text = dataReader["ten_phong_ban"].ToString();
                        ngayThamGiaTextBox.Text = dataReader["ngay_tham_gia"].ToString();
                        trangThaiTextBox.Text = dataReader["trang_thai"].ToString();

                        quyLabel.Text = "QUÝ " + dataReader["thang"].ToString() + "/" + dataReader["nam"].ToString();
                        hienThiHSLuongLabel.Text = dataReader["he_so_luong"].ToString() + " x";
                        hienThiLuongLabel.Text = string.Format("{0:N0} VND", Convert.ToDecimal(dataReader["luong_co_ban"]));
                        hienThiLuongThuongLabel.Text = string.Format("{0:N0} VND", Convert.ToDecimal(dataReader["luong_thuong"]));
                        hienThiLuongPhatLabel.Text = string.Format("{0:N0} VND", Convert.ToDecimal(dataReader["luong_phat"]));
                        tongLuongHienThiLabel.Text = string.Format("{0:N0} VND", Convert.ToDecimal(dataReader["tong_nhan"]));


                        int genderValue = Convert.ToInt32(dataReader["gioi_tinh"]);
                        gioiTinhComboBox.SelectedValue = genderValue;

                        updateOGData();
                        InitializeDataGridView(ID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi:" + ex.Message);
                    }
                    finally
                    {
                        dataReader.Close();
                        connection.Close();
                    }
                }
            }
        }
        //check txtBox.Text có đúng như trong database không
        private bool checkDatabase(Control control, string col)
        {
            using (SqlConnection connection = Connection.Connection.GetSqlConnection())
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM nhanvien WHERE {col} = @controlTxt";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@controlTxt", control.Text);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        // cài đặt cho combox box
        private void InitializeComboBox()
        {
            Dictionary<int, string> genderDictionary = new Dictionary<int, string>
            {
                {0, "Nữ" },
                {1, "Nam" },
                {2, "" },
            };

            gioiTinhComboBox.DataSource = new BindingSource(genderDictionary, null);
            gioiTinhComboBox.DisplayMember = "Value";
            gioiTinhComboBox.ValueMember = "Key";
            gioiTinhComboBox.SelectedValue = 2;
        }

        private void doiMatKhauStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.loginID = loginID;
            doiMatKhau.Show();
        }


        private void lấyThôngTinNgườiĐầuTiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxEventDetach();
            loginID = 1;
            InitializeData(loginID);
            txtBoxEventRetach();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            emailTextBox.Clear();
            diaChiTextBox.Clear();
            soDienThoaiTextBox.Clear();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = originalEmail;
            soDienThoaiTextBox.Text = originalSDT;
            diaChiTextBox.Text = originalDiaChi;
        }
        // kiểm soát trạng thái của nút save với nút reset
        private void txtBoxChanged(object sender, EventArgs e)
        {
            if (DataChanged(emailTextBox, originalEmail) == true || DataChanged(soDienThoaiTextBox, originalSDT) == true || DataChanged(diaChiTextBox, originalDiaChi) == true)
            {
                resetButton.Enabled = true;
            }
            else
            {
                resetButton.Enabled = false;
            }


            if (checkDatabase(emailTextBox, "email") == false || checkDatabase(soDienThoaiTextBox, "sdt") == false || checkDatabase(diaChiTextBox, "dia_chi") == false)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
        // không spam spacebar
        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (e.KeyChar == ' ')
            {
                if (textBox.Text.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }
        // load data từ textbox vào database
        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(soDienThoaiTextBox.Text) || string.IsNullOrWhiteSpace(diaChiTextBox.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = Connection.Connection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE nhanvien SET email = @emailTextBox, sdt = @sdtTextBox, dia_chi = @diaChiTextBox WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@emailTextBox", emailTextBox.Text);
                        command.Parameters.AddWithValue("@sdtTextBox", soDienThoaiTextBox.Text);
                        command.Parameters.AddWithValue("@diaChiTextBox", diaChiTextBox.Text);
                        command.Parameters.AddWithValue("@ID", loginID);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //field validation dành cho đống textbox
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Focus();
                emailTextBox.SelectAll();
            }
        }

        private void soDienThoaiTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(soDienThoaiTextBox.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                soDienThoaiTextBox.Focus();
                soDienThoaiTextBox.SelectAll();
            }
        }

        private void diaChiTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsValidAddress(diaChiTextBox.Text))
            {
                MessageBox.Show("Địa chỉ không hợp lệ hoặc vượt quá 100 ký tự. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                diaChiTextBox.Focus();
                diaChiTextBox.Select(0, 100);
            }
        }

        private bool IsValidEmail(string email)
        {
            // yoink trên mạng, đừng làm gì cả
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^[0-9]{7,11}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsValidAddress(string address)
        {
            // yoink trên mạng, đừng làm gì cả
            return !string.IsNullOrWhiteSpace(address) && Regex.IsMatch(address, @"^\s*\S.{1,100}\S\s*$");
        }

        // paint cái datagridview thành xám trắng mỗi hàng
        private void projectDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color color = (e.RowIndex % 2 == 0) ? Color.LightGray : Color.White;
            projectDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
        }

        private void iDNgườiĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID hiện tại " + loginID);
        }

        //load data từ ID được nhận khi vào form
        private void UserForm_Load(object sender, EventArgs e)
        {
            txtBoxEventDetach();
            InitializeData(loginID);
            txtBoxEventRetach();
        }
        // đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                logoutFlag = true;
                this.Close();
                dangnhap loginForm = new dangnhap();
                loginForm.Show();
            }

        }
        // đóng form, kiểm tra xem có phải là đăng xuất không, nếu không thì đóng phần mềm
        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logoutFlag)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!logoutFlag)
                    {
                        Application.Exit();
                    }
                }
            }
        }
    }
}
