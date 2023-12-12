using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quanlihosonhansu.Connection;
/*using static System.Net.Mime.MediaTypeNames;*/
using System.Diagnostics;

namespace quanlihosonhansu
{
    public partial class frmQLDuAn : Form
    {
        SqlConnection conn = Connection.Connection.GetSqlConnection();
        public frmQLDuAn()
        {
            InitializeComponent();
        }

        private void frmQLDuAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        DataTable loadData(string sql)
        {
            var cmd = new SqlCommand(sql, conn);
            var da = new SqlDataAdapter(cmd); // Lay du lieu
            var dt = new DataTable();
            da.Fill(dt); // Do du lieu vao bang dt
            da.Dispose(); // Giai phong
            return dt;
        }
        private void frmQLDuAn_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvDA.DataSource = loadData("Select dbo.duan.id as MaDA, dbo.duan.ten as TenDA, dbo.duan.mo_ta as MoTa, dbo.duan.khach_hang_id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT from dbo.duan INNER JOIN dbo.khachhang ON dbo.duan.khach_hang_id = dbo.khachhang.id");
            conn.Close();
        }
        private void dgvDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDA.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDA.Rows[e.RowIndex];
                txtMaDA.Text = row.Cells[0].Value.ToString();
                txtTenDA.Text = row.Cells[1].Value.ToString();
                txtMoTa.Text = row.Cells[2].Value.ToString();
                txtKhachHangID.Text = row.Cells[3].Value.ToString();
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaDA.Text = "";
            txtTenDA.Text = "";
            txtMoTa.Text = "";
            txtKhachHangID.Text = "";
            txtTenDA.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDA.Text != "" && txtMoTa.Text != "" && txtKhachHangID.Text != "")
            {
                String sql = "Insert Into dbo.duan(ten, mo_ta, khach_hang_id) Values(@1, @2, @3)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.VarChar).Value = txtTenDA.Text;
                cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtMoTa.Text;
                cmd.Parameters.Add("@3", SqlDbType.Int).Value = Convert.ToInt32(txtKhachHangID.Text);
                int result = cmd.ExecuteNonQuery();
                dgvDA.DataSource = loadData("Select dbo.duan.id as MaDA, dbo.duan.ten as TenDA, dbo.duan.mo_ta as MoTa, dbo.duan.khach_hang_id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT from dbo.duan INNER JOIN dbo.khachhang ON dbo.duan.khach_hang_id = dbo.khachhang.id");

                if (result > 0)
                {
                    MessageBox.Show("Bạn đã thêm dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDA.Text = "";
                    txtTenDA.Text = "";
                    txtMoTa.Text = "";
                    txtKhachHangID.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn đã thêm dự án không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin dự án cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtTenDA.Text == "")
                {
                    txtTenDA.Focus();
                }
                else if (txtMoTa.Text == "")
                {
                    txtMoTa.Focus();
                }
                else
                {
                    txtKhachHangID.Focus();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDA.Text != "" && txtMoTa.Text != "" && txtKhachHangID.Text != "")
            {

                string sql = "Update dbo.duan Set ten = @1, mo_ta = @2, khach_hang_id = @3 Where id = @4";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.VarChar).Value = txtTenDA.Text;
                cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtMoTa.Text;
                cmd.Parameters.Add("@3", SqlDbType.Int).Value = Convert.ToInt32(txtKhachHangID.Text);
                cmd.Parameters.Add("@4", SqlDbType.Int).Value = Convert.ToInt32(txtMaDA.Text);
                int result = cmd.ExecuteNonQuery();
                dgvDA.DataSource = loadData("Select dbo.duan.id as MaDA, dbo.duan.ten as TenDA, dbo.duan.mo_ta as MoTa, dbo.duan.khach_hang_id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT from dbo.duan INNER JOIN dbo.khachhang ON dbo.duan.khach_hang_id = dbo.khachhang.id");

                if (result > 0)
                {
                    MessageBox.Show("Bạn đã sửa thông tin dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDA.Text = "";
                    txtTenDA.Text = "";
                    txtMoTa.Text = "";
                    txtKhachHangID.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn đã sửa thông tin dự án không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn dự án cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtTenDA.Text == "")
                {
                    txtTenDA.Focus();
                }
                else if (txtMoTa.Text == "")
                {
                    txtMoTa.Focus();
                }
                else
                {
                    txtKhachHangID.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete From dbo.duan Where id = @1";
            conn.Open();
            if (txtTenDA.Text != "" && txtMoTa.Text != "" && txtKhachHangID.Text != "")
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.Int).Value = Convert.ToInt32(txtMaDA.Text);
                if (MessageBox.Show("Bạn có muốn xóa dự án đang chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = cmd.ExecuteNonQuery();
                    dgvDA.DataSource = loadData("Select dbo.duan.id as MaDA, dbo.duan.ten as TenDA, dbo.duan.mo_ta as MoTa, dbo.duan.khach_hang_id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT from dbo.duan INNER JOIN dbo.khachhang ON dbo.duan.khach_hang_id = dbo.khachhang.id");
                    if (result > 0)
                    {
                        MessageBox.Show("Bạn đã xóa dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaDA.Text = "";
                        txtTenDA.Text = "";
                        txtMoTa.Text = "";
                        txtKhachHangID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã xóa dự án không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            conn.Close();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (txtTimKiem.Text.Length > 0)
            {
                string sql = "Select dbo.duan.id as MaDA, dbo.duan.ten as TenDA, dbo.duan.mo_ta as MoTa, dbo.duan.khach_hang_id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT from dbo.duan INNER JOIN dbo.khachhang ON dbo.duan.khach_hang_id = dbo.khachhang.id Where dbo.duan.ten Like '" + '%' + txtTimKiem.Text + '%' + "' Or dbo.khachhang.ten Like '" + '%' + txtTimKiem.Text + '%' + "'";
                dgvDA.DataSource = loadData(sql);
            }
            else
            {
                string sql = "Select dbo.duan.id as MaDA, dbo.duan.ten as TenDA, dbo.duan.mo_ta as MoTa, dbo.duan.khach_hang_id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT from dbo.duan, dbo.khachhang where dbo.duan.khach_hang_id = dbo.khachhang.id ";
                dgvDA.DataSource = loadData(sql);
            }
            conn.Close();
        }
    }
}
