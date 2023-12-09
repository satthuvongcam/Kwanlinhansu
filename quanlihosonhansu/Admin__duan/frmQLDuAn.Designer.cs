namespace quanlihosonhansu
{
    partial class frmQLDuAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTroLai = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaDA = new TextBox();
            txtTenDA = new TextBox();
            txtMoTa = new TextBox();
            txtKhachHangID = new TextBox();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgvDA = new DataGridView();
            btnNhap = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDA).BeginInit();
            SuspendLayout();
            // 
            // btnTroLai
            // 
            btnTroLai.Location = new Point(12, 12);
            btnTroLai.Name = "btnTroLai";
            btnTroLai.Size = new Size(94, 29);
            btnTroLai.TabIndex = 0;
            btnTroLai.Text = "Trở lại ";
            btnTroLai.UseVisualStyleBackColor = true;
            btnTroLai.Click += btnTroLai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 42);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 1;
            label1.Text = "Quản lý Dự Án";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 104);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã DA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 155);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên DA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 155);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã KH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 104);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 5;
            label5.Text = "Mô tả";
            // 
            // txtMaDA
            // 
            txtMaDA.Location = new Point(200, 101);
            txtMaDA.Name = "txtMaDA";
            txtMaDA.ReadOnly = true;
            txtMaDA.Size = new Size(199, 27);
            txtMaDA.TabIndex = 6;
            // 
            // txtTenDA
            // 
            txtTenDA.Location = new Point(200, 152);
            txtTenDA.Name = "txtTenDA";
            txtTenDA.Size = new Size(199, 27);
            txtTenDA.TabIndex = 7;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(546, 101);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(199, 27);
            txtMoTa.TabIndex = 8;
            // 
            // txtKhachHangID
            // 
            txtKhachHangID.Location = new Point(546, 152);
            txtKhachHangID.Name = "txtKhachHangID";
            txtKhachHangID.Size = new Size(199, 27);
            txtKhachHangID.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(200, 199);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(170, 27);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(480, 198);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(574, 198);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(76, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(668, 198);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(76, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvDA
            // 
            dgvDA.BackgroundColor = Color.White;
            dgvDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDA.GridColor = Color.White;
            dgvDA.Location = new Point(47, 250);
            dgvDA.Name = "dgvDA";
            dgvDA.RowHeadersWidth = 51;
            dgvDA.RowTemplate.Height = 29;
            dgvDA.Size = new Size(734, 188);
            dgvDA.TabIndex = 15;
            dgvDA.CellContentClick += dgvDA_CellContentClick;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(387, 199);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(76, 29);
            btnNhap.TabIndex = 16;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 203);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 17;
            label6.Text = "Tìm kiếm";
            // 
            // frmQLDuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 462);
            Controls.Add(label6);
            Controls.Add(btnNhap);
            Controls.Add(dgvDA);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtKhachHangID);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenDA);
            Controls.Add(txtMaDA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTroLai);
            Name = "frmQLDuAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Quản lý dự án";
            FormClosing += frmQLDuAn_FormClosing;
            Load += frmQLDuAn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTroLai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaDA;
        private TextBox txtTenDA;
        private TextBox txtMoTa;
        private TextBox txtKhachHangID;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvDA;
        private Button btnNhap;
        private Label label6;
    }
}