namespace quanlihosonhansu
{
    partial class frmQLKhachHang
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
            btnNhap = new Button();
            dgvKH = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTroLai = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            SuspendLayout();
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(337, 202);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(98, 45);
            btnNhap.TabIndex = 33;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // dgvKH
            // 
            dgvKH.BackgroundColor = Color.White;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.GridColor = Color.White;
            dgvKH.Location = new Point(51, 262);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 29;
            dgvKH.Size = new Size(734, 188);
            dgvKH.TabIndex = 32;
            dgvKH.CellContentClick += dgvKH_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.deletePic;
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.Location = new Point(654, 202);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 45);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.updatePic;
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(545, 201);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 45);
            btnSua.TabIndex = 30;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleLeft;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.addPic;
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.Location = new Point(441, 201);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 45);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleLeft;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(152, 210);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(170, 27);
            txtTimKiem.TabIndex = 28;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(522, 156);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(199, 27);
            txtSDT.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(522, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 25;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(176, 156);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(199, 27);
            txtTenKH.TabIndex = 24;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(176, 103);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(199, 27);
            txtMaKH.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 106);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 22;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 159);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 21;
            label4.Text = "SĐT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 159);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 20;
            label3.Text = "Tên KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 106);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Mã KH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 42);
            label1.Name = "label1";
            label1.Size = new Size(270, 38);
            label1.TabIndex = 18;
            label1.Text = "Quản lý Khách Hàng";
            // 
            // btnTroLai
            // 
            btnTroLai.Image = Properties.Resources.backPic;
            btnTroLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTroLai.Location = new Point(16, 12);
            btnTroLai.Name = "btnTroLai";
            btnTroLai.Size = new Size(98, 45);
            btnTroLai.TabIndex = 17;
            btnTroLai.Text = "Trở lại ";
            btnTroLai.TextAlign = ContentAlignment.MiddleRight;
            btnTroLai.UseVisualStyleBackColor = true;
            btnTroLai.Click += btnTroLai_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 213);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 34;
            label6.Text = "Tìm kiếm";
            // 
            // frmQLKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 462);
            Controls.Add(label6);
            Controls.Add(btnNhap);
            Controls.Add(dgvKH);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTroLai);
            Name = "frmQLKhachHang";
            Text = "form Quản lý khách hàng";
            FormClosing += frmQLKhachHang_FormClosing;
            Load += frmQLKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNhap;
        private DataGridView dgvKH;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTroLai;
        private Label label6;
    }
}