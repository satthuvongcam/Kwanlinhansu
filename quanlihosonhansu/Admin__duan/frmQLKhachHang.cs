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

namespace quanlihosonhansu
{
    public partial class frmQLKhachHang : Form
    {
        SqlConnection conn = Connection.Connection.GetSqlConnection();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
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

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvKH.DataSource = loadData("Select dbo.khachhang.id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT From dbo.khachhang");
            conn.Close();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKH.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtTenKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtEmail.Text != "" && txtSDT.Text != "")
            {
                String sql = "Insert Into dbo.khachhang(ten, email, sdt) Values(@1, @2, @3)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.VarChar).Value = txtTenKH.Text;
                cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@3", SqlDbType.VarChar).Value = txtSDT.Text;
                int result = cmd.ExecuteNonQuery();
                dgvKH.DataSource = loadData("Select dbo.khachhang.id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT From dbo.khachhang");

                if (result > 0)
                {
                    MessageBox.Show("Bạn đã thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtEmail.Text = "";
                    txtSDT.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn đã thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                if(txtTenKH.Text == "" && txtEmail.Text == "" && txtSDT.Text == "")
                {
                    MessageBox.Show("Bạn cần điền đầy đủ tất cả thông tin trước khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống trường tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenKH.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống trường email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else
                {
                    MessageBox.Show("Bạn không được để trống trường số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDT.Focus();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtEmail.Text != "" && txtSDT.Text != "")
            {
                String sql = "Update dbo.khachhang Set ten = @1, email = @2, sdt = @3 Where id = @4";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.VarChar).Value = txtTenKH.Text;
                cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@3", SqlDbType.VarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@4", SqlDbType.Int).Value = Convert.ToInt32(txtMaKH.Text);
                int result = cmd.ExecuteNonQuery();
                dgvKH.DataSource = loadData("Select dbo.khachhang.id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT From dbo.khachhang");

                if (result > 0)
                {
                    MessageBox.Show("Bạn đã sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtEmail.Text = "";
                    txtSDT.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn đã sửa thông tin khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtTenKH.Text == "")
                {
                    txtTenKH.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    txtEmail.Focus();
                }
                else
                {
                    txtSDT.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete From dbo.khachhang Where id = @1";
            conn.Open();
            if (txtTenKH.Text != "" && txtEmail.Text != "" && txtSDT.Text != "")
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.Int).Value = Convert.ToInt32(txtMaKH.Text);
                if (MessageBox.Show("Bạn có muốn xóa khách hàng đang chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = cmd.ExecuteNonQuery();
                    dgvKH.DataSource = loadData("Select dbo.khachhang.id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT From dbo.khachhang");
                    if (result > 0)
                    {
                        MessageBox.Show("Bạn đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaKH.Text = "";
                        txtTenKH.Text = "";
                        txtEmail.Text = "";
                        txtSDT.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã xóa khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            conn.Close();
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (txtTimKiem.Text.Length > 0)
            {
                string sql = "Select * From dbo.khachhang Where ten Like '" + '%' + txtTimKiem.Text + '%' + "' Or email Like '" + '%' + txtTimKiem.Text + '%' + "' Or sdt Like '" + '%' + txtTimKiem.Text + '%' + "'";
                dgvKH.DataSource = loadData(sql);
            }
            else
            {
                string sql = "Select dbo.khachhang.id as MaKH, dbo.khachhang.ten as TenKH, dbo.khachhang.email as Email, dbo.khachhang.sdt as SDT From dbo.khachhang";
                dgvKH.DataSource = loadData(sql);
            }
            conn.Close();
        }
    }
}
