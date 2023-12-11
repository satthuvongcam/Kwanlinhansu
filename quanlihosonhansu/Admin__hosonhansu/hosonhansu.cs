using Microsoft.VisualBasic;
using quanlihosonhansu.Admin__hosonhansu.Functions;
using quanlihosonhansu.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlihosonhansu.Admin__hosonhansu
{
    public partial class hosonhansu : Form
    {
        string sql = "";
        IFormatProvider culture = new System.Globalization.CultureInfo("en-GB", true);
        DataTable dt;
        SqlConnection conn = Connection.Connection.GetSqlConnection();
        SqlCommand command;
        public hosonhansu()
        {
            InitializeComponent();
        }

        private void assignComboBoxes()
        {
            // Assigning comboboxes default value

            assignCombo.assigningComboDB(comboLevel, "chucvu", "ten" , "id" );
            assignCombo.assigningComboDB(comboRoom, "phongban", "ten" , "id" );

            // Assigning comboboxes with custom value

            string[,] genderArr = Datas.getGender();
            string[,] staffArr = Datas.getStaffStatus();
            string[,] statusArr = Datas.getWorkStatus();

            assignCombo.assigningComboCustom(comboGender, genderArr);
            assignCombo.assigningComboCustom(comboStatus, statusArr);
            assignCombo.assigningComboCustom(comboStaff, staffArr);
        }

        private void hosonhansu_Load(object sender, EventArgs e)
        {
            sql = "SELECT n.id, n.ho_ten, n.ngay_sinh, " +
              "CASE n.gioi_tinh " +
              "   WHEN '0' THEN 'male' " +
              "   WHEN '1' THEN 'female' " +
              "   WHEN '2' THEN 'other' " +
              "   ELSE 'unknown' END AS gioi_tinh, " +
              "n.email, n.sdt, n.dia_chi, n.ngay_tham_gia, n.luong_co_ban, n.he_so_luong, " +
              "p.ten AS phong_ban_ten, n.is_staff, n.trang_thai " +
              "FROM nhanvien n " +
              "INNER JOIN phongban p ON n.phong_ban_id = p.id";
            dataGridView1.DataSource = Getdata.getData(sql);

            // Default settings
            txtId.Enabled = false; // as always
            assignComboBoxes();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateTimeJoin.Enabled = false;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // password default la ngay sinh, ngay tham gia default la vao hom nay"
                string idNv = txtId.Text;
                string prevsql = sql;
                conn.Open();
                sql = "Insert into nhanvien " +
                    "(ho_ten, ngay_sinh, gioi_tinh, email, sdt, dia_chi, luong_co_ban, he_so_luong, trang_thai, is_staff, phong_ban_id, chuc_vu_id, password, ngay_tham_gia) " +
                "Values " +
                "('" + txtName.Text +
                "','" + ConvertToDDMMYYYY.parseDateTime(dateTimeBirth.Value) +
                "','" + comboGender.SelectedValue +
                "','" + txtEmail.Text +
                "','" + txtPhone.Text +
                "','" + txtAddr.Text +
                "','" + txtSalary.Text +
                "','" + txtMulti.Text +
                "','" + comboStatus.SelectedValue +
                "','" + comboStaff.SelectedValue +
                "','" + comboRoom.SelectedValue +
                "','" + comboLevel.SelectedValue +
                "','" + ConvertToDDMMYYYY.parseDateTime(dateTimeBirth.Value) +
                "','" + ConvertToDDMMYYYY.parseDateTime(DateTime.Today) +
                "')";

                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                conn.Close();

                dataGridView1.DataSource = Getdata.getData(prevsql);
                sql = prevsql;

                MessageBox.Show("Success!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string idNv = txtId.Text;
                string prevsql = sql;
                conn.Open();
                sql = "Update nhanvien " +
                "Set " +
                "ho_ten = '" + txtName.Text + "' , " +
                "ngay_sinh = '" + ConvertToDDMMYYYY.parseDateTime(dateTimeBirth.Value) + "', " +
                "gioi_tinh = '" + comboGender.SelectedValue + "' , " +
                "email = '" + txtEmail.Text + "' , " +
                "sdt = '" + txtPhone.Text + "' , " +
                "dia_chi = '" + txtAddr.Text + "' , " +
                "luong_co_ban = '" + txtSalary.Text + "' , " +
                "he_so_luong = '" + txtMulti.Text + "' , " +
                "trang_thai = '" + comboStatus.SelectedValue + "' , " +
                "is_staff = '" + comboStaff.SelectedValue + "', " +
                "phong_ban_id = '" + comboRoom.SelectedValue + "' , " +
                "chuc_vu_id = '" + comboLevel.SelectedValue + "' " +
                "Where id = " + idNv;

                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                conn.Close();

                dataGridView1.DataSource = Getdata.getData(prevsql);
                sql = prevsql;
                
                MessageBox.Show("Success!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // saving the prev state
                string prevsql = sql;

                string idNv = txtId.Text;
                
                conn.Open();
                sql = "delete from nhanvien_duan where nhanvien_id = " + idNv;
                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                sql = "delete from luong where nhan_vien_id = " + idNv;
                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                sql = "delete from nhanvien where id = " + idNv;
                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                conn.Close();
                // delete kiluat and khenthuong similar to above if needed (if table have data)

                // re-Render
                dataGridView1.DataSource = Getdata.getData(prevsql);
                sql = prevsql;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id, ho_ten, ngay_sinh, gioi_tinh, email, sdt, dia_chi, ngay_tham_gia, luong_co_ban" +
            // he_so_luong, chuc_vu_id, phong_ban_id, is_staff from nhanvien"
            string prevsql = sql;

            int i;
            int phongbanSelectedValue = -1;
            int chucVuSelectedValue = -1;
            int gender = -1;
            int isStaff = -1;
            int currentStatus = -1;
            i = e.RowIndex;

            if (i >= 0)
            {
                // handling texts and datetime
                txtId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txtAddr.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                txtSalary.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                txtMulti.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

                dateTimeBirth.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value, culture);
                dateTimeJoin.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[7].Value, culture);

                // handling comboBoxes
                sql = "select phong_ban_id from nhanvien where Id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                dt = Getdata.getData(sql);
                if (dt.Rows.Count > 0 && dt.Rows[0]["phong_ban_id"] != DBNull.Value)
                {
                    phongbanSelectedValue = Convert.ToInt32(dt.Rows[0]["phong_ban_id"]);
                }
                sql = "select chuc_vu_id from nhanvien where Id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                dt = Getdata.getData(sql);
                if (dt.Rows.Count > 0 && dt.Rows[0]["chuc_vu_id"] != DBNull.Value)
                {
                    chucVuSelectedValue = Convert.ToInt32(dt.Rows[0]["chuc_vu_id"]);
                }
                sql = "select gioi_tinh from nhanvien where Id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                dt = Getdata.getData(sql);
                if (dt.Rows.Count > 0 && dt.Rows[0]["gioi_tinh"] != DBNull.Value)
                {
                    gender = Convert.ToInt32(dt.Rows[0]["gioi_tinh"]);
                }
                sql = "select is_staff from nhanvien where Id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                dt = Getdata.getData(sql);
                if (dt.Rows.Count > 0 && dt.Rows[0]["is_staff"] != DBNull.Value)
                {
                    isStaff = Convert.ToInt32(dt.Rows[0]["is_staff"]);
                }
                sql = "select trang_thai from nhanvien where Id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                dt = Getdata.getData(sql);
                if (dt.Rows.Count > 0 && dt.Rows[0]["trang_thai"] != DBNull.Value)
                {
                    currentStatus = Convert.ToInt32(dt.Rows[0]["trang_thai"]);
                }

                comboRoom.SelectedValue = phongbanSelectedValue;
                comboLevel.SelectedValue = chucVuSelectedValue;
                comboGender.SelectedValue = gender;
                comboStaff.SelectedValue = isStaff;
                comboStatus.SelectedValue = currentStatus;

           }
            sql = prevsql;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT n.id, n.ho_ten, n.ngay_sinh, " +
              "CASE n.gioi_tinh " +
              "   WHEN '0' THEN 'male' " +
              "   WHEN '1' THEN 'female' " +
              "   WHEN '2' THEN 'other' " +
              "   ELSE 'unknown' END AS gioi_tinh, " +
              "n.email, n.sdt, n.dia_chi, n.ngay_tham_gia, n.luong_co_ban, n.he_so_luong, " +
              "p.ten AS phong_ban_ten, n.is_staff, n.trang_thai " +
              "FROM nhanvien n " +
              "INNER JOIN phongban p ON n.phong_ban_id = p.id " +
              "WHERE n.ho_ten LIKE '%" + txtSearch.Text + "%'";

            dt = Getdata.getData(sql);
            dataGridView1.DataSource = dt;
        }
    }
}
