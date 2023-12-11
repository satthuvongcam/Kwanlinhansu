namespace quanlihosonhansu.User__things
{
    partial class UserForm
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
            saveButton = new Button();
            deleteButton = new Button();
            functionFlowPanel = new FlowLayoutPanel();
            resetButton = new Button();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            stripMenu = new MenuStrip();
            debugToolStripMenuItem = new ToolStripMenuItem();
            lấyThôngTinNgườiĐầuTiênToolStripMenuItem = new ToolStripMenuItem();
            iDNgườiĐăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tongLuongThucNhanTable = new TableLayoutPanel();
            tongLuongLabel = new Label();
            tongLuongHienThiLabel = new Label();
            chiTietLuongTable = new TableLayoutPanel();
            quyLabel = new Label();
            luongCoBanLabel = new Label();
            heSoLuong = new Label();
            luongThuongLabel = new Label();
            luongPhatLabel = new Label();
            hienThiLuongLabel = new Label();
            hienThiHSLuongLabel = new Label();
            hienThiLuongThuongLabel = new Label();
            hienThiLuongPhatLabel = new Label();
            projectDataGridView = new DataGridView();
            thongTinTable = new TableLayoutPanel();
            gioiTinhLabel = new Label();
            phongBanLabel = new Label();
            chucVuLabel = new Label();
            diaChiLabel = new Label();
            sdtLabel = new Label();
            emailLabel = new Label();
            hoTenTextBox = new TextBox();
            ngaySinhLabel = new Label();
            hoTenLabel = new Label();
            ngaySinhTextBox = new TextBox();
            emailTextBox = new TextBox();
            soDienThoaiTextBox = new TextBox();
            diaChiTextBox = new TextBox();
            chucVuTextBox = new TextBox();
            phongBanTextBox = new TextBox();
            gioiTinhComboBox = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            ngayThamGiaTextBox = new TextBox();
            trangThaiTextBox = new TextBox();
            ngayThamGiaLabel = new Label();
            trangThaiLabel = new Label();
            luongTable = new TableLayoutPanel();
            functionFlowPanel.SuspendLayout();
            stripMenu.SuspendLayout();
            tongLuongThucNhanTable.SuspendLayout();
            chiTietLuongTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectDataGridView).BeginInit();
            thongTinTable.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            luongTable.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Transparent;
            saveButton.Enabled = false;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Image = Properties.Resources.saveIcon;
            saveButton.Location = new Point(5, 5);
            saveButton.Margin = new Padding(5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(127, 39);
            saveButton.TabIndex = 1;
            saveButton.Text = "Lưu thay đổi";
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Left;
            deleteButton.BackColor = Color.Transparent;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Image = Properties.Resources.eraserIcon;
            deleteButton.Location = new Point(140, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(127, 39);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Xóa tất cả";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // functionFlowPanel
            // 
            functionFlowPanel.AutoSize = true;
            functionFlowPanel.Controls.Add(saveButton);
            functionFlowPanel.Controls.Add(deleteButton);
            functionFlowPanel.Controls.Add(resetButton);
            functionFlowPanel.Dock = DockStyle.Top;
            functionFlowPanel.Location = new Point(15, 24);
            functionFlowPanel.Margin = new Padding(5);
            functionFlowPanel.Name = "functionFlowPanel";
            functionFlowPanel.Size = new Size(1016, 49);
            functionFlowPanel.TabIndex = 4;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Left;
            resetButton.BackColor = Color.Transparent;
            resetButton.Enabled = false;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Image = Properties.Resources.resetICon;
            resetButton.Location = new Point(273, 5);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(132, 39);
            resetButton.TabIndex = 5;
            resetButton.Text = "Đặt lại thay đổi";
            resetButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinCáNhânToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Padding = new Padding(0, 0, 4, 0);
            thôngTinCáNhânToolStripMenuItem.Size = new Size(69, 20);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin";
            // 
            // doiMatKhauStripMenuItem
            // 
            doiMatKhauStripMenuItem.Name = "doiMatKhauStripMenuItem";
            doiMatKhauStripMenuItem.Size = new Size(180, 22);
            doiMatKhauStripMenuItem.Text = "Đổi mật khẩu";
            doiMatKhauStripMenuItem.Click += doiMatKhauStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(180, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // stripMenu
            // 
            stripMenu.Items.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, debugToolStripMenuItem });
            stripMenu.Location = new Point(15, 0);
            stripMenu.Name = "stripMenu";
            stripMenu.Padding = new Padding(0, 2, 0, 2);
            stripMenu.Size = new Size(1016, 24);
            stripMenu.TabIndex = 3;
            stripMenu.Text = "menuStrip1";
            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lấyThôngTinNgườiĐầuTiênToolStripMenuItem, iDNgườiĐăngNhậpToolStripMenuItem });
            debugToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            debugToolStripMenuItem.Size = new Size(55, 20);
            debugToolStripMenuItem.Text = "Debug";
            // 
            // lấyThôngTinNgườiĐầuTiênToolStripMenuItem
            // 
            lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Name = "lấyThôngTinNgườiĐầuTiênToolStripMenuItem";
            lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Size = new Size(231, 22);
            lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Text = "Lấy thông tin người đầu tiên";
            lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Click += lấyThôngTinNgườiĐầuTiênToolStripMenuItem_Click;
            // 
            // iDNgườiĐăngNhậpToolStripMenuItem
            // 
            iDNgườiĐăngNhậpToolStripMenuItem.Name = "iDNgườiĐăngNhậpToolStripMenuItem";
            iDNgườiĐăngNhậpToolStripMenuItem.Size = new Size(231, 22);
            iDNgườiĐăngNhậpToolStripMenuItem.Text = "ID người đăng nhập";
            iDNgườiĐăngNhậpToolStripMenuItem.Click += iDNgườiĐăngNhậpToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.880352F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.70655F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.70655F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.70655F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(508, 3);
            panel1.Name = "panel1";
            luongTable.SetRowSpan(panel1, 2);
            panel1.Size = new Size(1, 332);
            panel1.TabIndex = 11;
            // 
            // tongLuongThucNhanTable
            // 
            tongLuongThucNhanTable.BackColor = Color.Transparent;
            tongLuongThucNhanTable.ColumnCount = 3;
            tongLuongThucNhanTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.50235F));
            tongLuongThucNhanTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.49765F));
            tongLuongThucNhanTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tongLuongThucNhanTable.Controls.Add(tongLuongLabel, 0, 0);
            tongLuongThucNhanTable.Controls.Add(tongLuongHienThiLabel, 1, 0);
            tongLuongThucNhanTable.Location = new Point(3, 299);
            tongLuongThucNhanTable.Name = "tongLuongThucNhanTable";
            tongLuongThucNhanTable.RowCount = 1;
            tongLuongThucNhanTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tongLuongThucNhanTable.Size = new Size(499, 36);
            tongLuongThucNhanTable.TabIndex = 10;
            // 
            // tongLuongLabel
            // 
            tongLuongLabel.AutoSize = true;
            tongLuongLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tongLuongLabel.Location = new Point(3, 0);
            tongLuongLabel.Name = "tongLuongLabel";
            tongLuongLabel.Size = new Size(233, 23);
            tongLuongLabel.TabIndex = 0;
            tongLuongLabel.Text = "Tổng Lương Thực Nhận";
            // 
            // tongLuongHienThiLabel
            // 
            tongLuongHienThiLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tongLuongHienThiLabel.AutoSize = true;
            tongLuongHienThiLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tongLuongHienThiLabel.Location = new Point(394, 0);
            tongLuongHienThiLabel.Name = "tongLuongHienThiLabel";
            tongLuongHienThiLabel.Size = new Size(68, 23);
            tongLuongHienThiLabel.TabIndex = 1;
            tongLuongHienThiLabel.Text = "label1";
            // 
            // chiTietLuongTable
            // 
            chiTietLuongTable.Anchor = AnchorStyles.Left;
            chiTietLuongTable.BackColor = Color.Transparent;
            chiTietLuongTable.ColumnCount = 3;
            chiTietLuongTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            chiTietLuongTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.12024F));
            chiTietLuongTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.61322641F));
            chiTietLuongTable.Controls.Add(quyLabel, 0, 0);
            chiTietLuongTable.Controls.Add(luongCoBanLabel, 0, 1);
            chiTietLuongTable.Controls.Add(heSoLuong, 0, 2);
            chiTietLuongTable.Controls.Add(luongThuongLabel, 0, 3);
            chiTietLuongTable.Controls.Add(luongPhatLabel, 0, 4);
            chiTietLuongTable.Controls.Add(hienThiLuongLabel, 1, 1);
            chiTietLuongTable.Controls.Add(hienThiHSLuongLabel, 1, 2);
            chiTietLuongTable.Controls.Add(hienThiLuongThuongLabel, 1, 3);
            chiTietLuongTable.Controls.Add(hienThiLuongPhatLabel, 1, 4);
            chiTietLuongTable.Location = new Point(3, 9);
            chiTietLuongTable.Name = "chiTietLuongTable";
            chiTietLuongTable.RowCount = 5;
            chiTietLuongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            chiTietLuongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            chiTietLuongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            chiTietLuongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            chiTietLuongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            chiTietLuongTable.Size = new Size(499, 278);
            chiTietLuongTable.TabIndex = 6;
            // 
            // quyLabel
            // 
            quyLabel.AutoSize = true;
            quyLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quyLabel.Location = new Point(3, 0);
            quyLabel.Name = "quyLabel";
            quyLabel.Padding = new Padding(0, 5, 0, 0);
            quyLabel.Size = new Size(44, 24);
            quyLabel.TabIndex = 0;
            quyLabel.Text = "QUÝ";
            // 
            // luongCoBanLabel
            // 
            luongCoBanLabel.Anchor = AnchorStyles.Left;
            luongCoBanLabel.AutoSize = true;
            luongCoBanLabel.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            luongCoBanLabel.Location = new Point(3, 74);
            luongCoBanLabel.Name = "luongCoBanLabel";
            luongCoBanLabel.Size = new Size(86, 16);
            luongCoBanLabel.TabIndex = 1;
            luongCoBanLabel.Text = "Lương Cơ Bản";
            // 
            // heSoLuong
            // 
            heSoLuong.Anchor = AnchorStyles.Left;
            heSoLuong.AutoSize = true;
            heSoLuong.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            heSoLuong.Location = new Point(3, 129);
            heSoLuong.Name = "heSoLuong";
            heSoLuong.Size = new Size(80, 16);
            heSoLuong.TabIndex = 2;
            heSoLuong.Text = "Hệ Số Lương";
            // 
            // luongThuongLabel
            // 
            luongThuongLabel.Anchor = AnchorStyles.Left;
            luongThuongLabel.AutoSize = true;
            luongThuongLabel.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            luongThuongLabel.Location = new Point(3, 184);
            luongThuongLabel.Name = "luongThuongLabel";
            luongThuongLabel.Size = new Size(90, 16);
            luongThuongLabel.TabIndex = 3;
            luongThuongLabel.Text = "Lương Thưởng";
            // 
            // luongPhatLabel
            // 
            luongPhatLabel.Anchor = AnchorStyles.Left;
            luongPhatLabel.AutoSize = true;
            luongPhatLabel.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            luongPhatLabel.Location = new Point(3, 241);
            luongPhatLabel.Name = "luongPhatLabel";
            luongPhatLabel.Size = new Size(71, 16);
            luongPhatLabel.TabIndex = 4;
            luongPhatLabel.Text = "Lương Phạt";
            // 
            // hienThiLuongLabel
            // 
            hienThiLuongLabel.Anchor = AnchorStyles.Right;
            hienThiLuongLabel.AutoSize = true;
            hienThiLuongLabel.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hienThiLuongLabel.Location = new Point(417, 74);
            hienThiLuongLabel.Name = "hienThiLuongLabel";
            hienThiLuongLabel.Size = new Size(45, 16);
            hienThiLuongLabel.TabIndex = 5;
            hienThiLuongLabel.Text = "label6";
            // 
            // hienThiHSLuongLabel
            // 
            hienThiHSLuongLabel.Anchor = AnchorStyles.Right;
            hienThiHSLuongLabel.AutoSize = true;
            hienThiHSLuongLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hienThiHSLuongLabel.Location = new Point(417, 129);
            hienThiHSLuongLabel.Name = "hienThiHSLuongLabel";
            hienThiHSLuongLabel.Size = new Size(45, 17);
            hienThiHSLuongLabel.TabIndex = 6;
            hienThiHSLuongLabel.Text = "label7";
            // 
            // hienThiLuongThuongLabel
            // 
            hienThiLuongThuongLabel.Anchor = AnchorStyles.Right;
            hienThiLuongThuongLabel.AutoSize = true;
            hienThiLuongThuongLabel.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hienThiLuongThuongLabel.Location = new Point(417, 184);
            hienThiLuongThuongLabel.Name = "hienThiLuongThuongLabel";
            hienThiLuongThuongLabel.Size = new Size(45, 16);
            hienThiLuongThuongLabel.TabIndex = 7;
            hienThiLuongThuongLabel.Text = "label8";
            // 
            // hienThiLuongPhatLabel
            // 
            hienThiLuongPhatLabel.Anchor = AnchorStyles.Right;
            hienThiLuongPhatLabel.AutoSize = true;
            hienThiLuongPhatLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hienThiLuongPhatLabel.Location = new Point(417, 240);
            hienThiLuongPhatLabel.Name = "hienThiLuongPhatLabel";
            hienThiLuongPhatLabel.Size = new Size(45, 17);
            hienThiLuongPhatLabel.TabIndex = 8;
            hienThiLuongPhatLabel.Text = "label9";
            // 
            // projectDataGridView
            // 
            projectDataGridView.AllowUserToAddRows = false;
            projectDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            projectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            luongTable.SetColumnSpan(projectDataGridView, 3);
            projectDataGridView.Location = new Point(3, 341);
            projectDataGridView.Name = "projectDataGridView";
            projectDataGridView.ReadOnly = true;
            projectDataGridView.RowHeadersVisible = false;
            projectDataGridView.RowTemplate.Height = 25;
            projectDataGridView.Size = new Size(1004, 138);
            projectDataGridView.TabIndex = 4;
            projectDataGridView.RowPrePaint += projectDataGridView_RowPrePaint;
            // 
            // thongTinTable
            // 
            thongTinTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            thongTinTable.BackColor = Color.Transparent;
            thongTinTable.ColumnCount = 2;
            thongTinTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            thongTinTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            thongTinTable.Controls.Add(gioiTinhLabel, 0, 2);
            thongTinTable.Controls.Add(phongBanLabel, 0, 9);
            thongTinTable.Controls.Add(chucVuLabel, 0, 8);
            thongTinTable.Controls.Add(diaChiLabel, 0, 6);
            thongTinTable.Controls.Add(sdtLabel, 0, 5);
            thongTinTable.Controls.Add(emailLabel, 0, 4);
            thongTinTable.Controls.Add(hoTenTextBox, 1, 0);
            thongTinTable.Controls.Add(ngaySinhLabel, 0, 1);
            thongTinTable.Controls.Add(hoTenLabel, 0, 0);
            thongTinTable.Controls.Add(ngaySinhTextBox, 1, 1);
            thongTinTable.Controls.Add(emailTextBox, 1, 4);
            thongTinTable.Controls.Add(soDienThoaiTextBox, 1, 5);
            thongTinTable.Controls.Add(diaChiTextBox, 1, 6);
            thongTinTable.Controls.Add(chucVuTextBox, 1, 8);
            thongTinTable.Controls.Add(phongBanTextBox, 1, 9);
            thongTinTable.Controls.Add(gioiTinhComboBox, 1, 2);
            thongTinTable.Location = new Point(513, 3);
            thongTinTable.Name = "thongTinTable";
            thongTinTable.RowCount = 10;
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999999F));
            thongTinTable.Size = new Size(500, 290);
            thongTinTable.TabIndex = 1;
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.Anchor = AnchorStyles.Left;
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gioiTinhLabel.Location = new Point(3, 65);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new Size(54, 14);
            gioiTinhLabel.TabIndex = 2;
            gioiTinhLabel.Text = "Giới Tính";
            gioiTinhLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // phongBanLabel
            // 
            phongBanLabel.Anchor = AnchorStyles.Left;
            phongBanLabel.AutoSize = true;
            phongBanLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phongBanLabel.Location = new Point(3, 268);
            phongBanLabel.Name = "phongBanLabel";
            phongBanLabel.Size = new Size(66, 14);
            phongBanLabel.TabIndex = 7;
            phongBanLabel.Text = "Phòng Ban";
            phongBanLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // chucVuLabel
            // 
            chucVuLabel.Anchor = AnchorStyles.Left;
            chucVuLabel.AutoSize = true;
            chucVuLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chucVuLabel.Location = new Point(3, 239);
            chucVuLabel.Name = "chucVuLabel";
            chucVuLabel.Size = new Size(54, 14);
            chucVuLabel.TabIndex = 6;
            chucVuLabel.Text = "Chức Vụ";
            chucVuLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // diaChiLabel
            // 
            diaChiLabel.Anchor = AnchorStyles.Left;
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            diaChiLabel.Location = new Point(3, 181);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new Size(43, 14);
            diaChiLabel.TabIndex = 5;
            diaChiLabel.Text = "Địa Chỉ";
            diaChiLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // sdtLabel
            // 
            sdtLabel.Anchor = AnchorStyles.Left;
            sdtLabel.AutoSize = true;
            sdtLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sdtLabel.Location = new Point(3, 152);
            sdtLabel.Name = "sdtLabel";
            sdtLabel.Size = new Size(83, 14);
            sdtLabel.TabIndex = 4;
            sdtLabel.Text = "Số Điện Thoại";
            sdtLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Left;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(3, 123);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(34, 14);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            emailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // hoTenTextBox
            // 
            hoTenTextBox.Anchor = AnchorStyles.None;
            hoTenTextBox.BackColor = SystemColors.ScrollBar;
            hoTenTextBox.Enabled = false;
            hoTenTextBox.Location = new Point(103, 3);
            hoTenTextBox.Name = "hoTenTextBox";
            hoTenTextBox.ReadOnly = true;
            hoTenTextBox.Size = new Size(393, 23);
            hoTenTextBox.TabIndex = 8;
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.Anchor = AnchorStyles.Left;
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ngaySinhLabel.Location = new Point(3, 36);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new Size(61, 14);
            ngaySinhLabel.TabIndex = 1;
            ngaySinhLabel.Text = "Ngày Sinh";
            ngaySinhLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // hoTenLabel
            // 
            hoTenLabel.Anchor = AnchorStyles.Left;
            hoTenLabel.AutoSize = true;
            hoTenLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hoTenLabel.Location = new Point(3, 7);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new Size(48, 14);
            hoTenLabel.TabIndex = 9;
            hoTenLabel.Text = "Họ Tên";
            // 
            // ngaySinhTextBox
            // 
            ngaySinhTextBox.Anchor = AnchorStyles.Left;
            ngaySinhTextBox.BackColor = SystemColors.ScrollBar;
            ngaySinhTextBox.Enabled = false;
            ngaySinhTextBox.Location = new Point(103, 32);
            ngaySinhTextBox.Name = "ngaySinhTextBox";
            ngaySinhTextBox.ReadOnly = true;
            ngaySinhTextBox.Size = new Size(393, 23);
            ngaySinhTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Left;
            emailTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(103, 119);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(393, 23);
            emailTextBox.TabIndex = 12;
            emailTextBox.TextChanged += txtBoxChanged;
            emailTextBox.KeyPress += txtKeyPress;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // soDienThoaiTextBox
            // 
            soDienThoaiTextBox.Anchor = AnchorStyles.Left;
            soDienThoaiTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            soDienThoaiTextBox.Location = new Point(103, 148);
            soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            soDienThoaiTextBox.Size = new Size(393, 23);
            soDienThoaiTextBox.TabIndex = 13;
            soDienThoaiTextBox.TextChanged += txtBoxChanged;
            soDienThoaiTextBox.KeyPress += txtKeyPress;
            soDienThoaiTextBox.Leave += soDienThoaiTextBox_Leave;
            // 
            // diaChiTextBox
            // 
            diaChiTextBox.Anchor = AnchorStyles.Left;
            diaChiTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            diaChiTextBox.Location = new Point(103, 177);
            diaChiTextBox.Name = "diaChiTextBox";
            diaChiTextBox.Size = new Size(393, 23);
            diaChiTextBox.TabIndex = 14;
            diaChiTextBox.TextChanged += txtBoxChanged;
            diaChiTextBox.KeyPress += txtKeyPress;
            diaChiTextBox.Leave += diaChiTextBox_Leave;
            // 
            // chucVuTextBox
            // 
            chucVuTextBox.Anchor = AnchorStyles.Left;
            chucVuTextBox.BackColor = SystemColors.ScrollBar;
            chucVuTextBox.Enabled = false;
            chucVuTextBox.Location = new Point(103, 235);
            chucVuTextBox.Name = "chucVuTextBox";
            chucVuTextBox.ReadOnly = true;
            chucVuTextBox.Size = new Size(393, 23);
            chucVuTextBox.TabIndex = 15;
            // 
            // phongBanTextBox
            // 
            phongBanTextBox.Anchor = AnchorStyles.Left;
            phongBanTextBox.BackColor = SystemColors.ScrollBar;
            phongBanTextBox.Enabled = false;
            phongBanTextBox.Location = new Point(103, 264);
            phongBanTextBox.Name = "phongBanTextBox";
            phongBanTextBox.ReadOnly = true;
            phongBanTextBox.Size = new Size(393, 23);
            phongBanTextBox.TabIndex = 16;
            // 
            // gioiTinhComboBox
            // 
            gioiTinhComboBox.BackColor = SystemColors.Window;
            gioiTinhComboBox.Dock = DockStyle.Fill;
            gioiTinhComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gioiTinhComboBox.Enabled = false;
            gioiTinhComboBox.FormattingEnabled = true;
            gioiTinhComboBox.Items.AddRange(new object[] { "Nữ", "Nam" });
            gioiTinhComboBox.Location = new Point(103, 61);
            gioiTinhComboBox.Name = "gioiTinhComboBox";
            gioiTinhComboBox.Size = new Size(394, 23);
            gioiTinhComboBox.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.880352F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.70655F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.70655F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.70655F));
            tableLayoutPanel3.Controls.Add(ngayThamGiaTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(trangThaiTextBox, 3, 0);
            tableLayoutPanel3.Controls.Add(ngayThamGiaLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(trangThaiLabel, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(513, 299);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(500, 36);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // ngayThamGiaTextBox
            // 
            ngayThamGiaTextBox.BackColor = SystemColors.ScrollBar;
            ngayThamGiaTextBox.Enabled = false;
            ngayThamGiaTextBox.Location = new Point(102, 3);
            ngayThamGiaTextBox.Name = "ngayThamGiaTextBox";
            ngayThamGiaTextBox.ReadOnly = true;
            ngayThamGiaTextBox.Size = new Size(119, 23);
            ngayThamGiaTextBox.TabIndex = 2;
            // 
            // trangThaiTextBox
            // 
            trangThaiTextBox.BackColor = SystemColors.ScrollBar;
            trangThaiTextBox.Enabled = false;
            trangThaiTextBox.Location = new Point(368, 3);
            trangThaiTextBox.Name = "trangThaiTextBox";
            trangThaiTextBox.ReadOnly = true;
            trangThaiTextBox.Size = new Size(128, 23);
            trangThaiTextBox.TabIndex = 3;
            // 
            // ngayThamGiaLabel
            // 
            ngayThamGiaLabel.AutoSize = true;
            ngayThamGiaLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ngayThamGiaLabel.Location = new Point(3, 0);
            ngayThamGiaLabel.Name = "ngayThamGiaLabel";
            ngayThamGiaLabel.Padding = new Padding(0, 5, 0, 0);
            ngayThamGiaLabel.Size = new Size(89, 19);
            ngayThamGiaLabel.TabIndex = 0;
            ngayThamGiaLabel.Text = "Ngày Tham Gia";
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Location = new Point(301, 0);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Padding = new Padding(0, 5, 0, 0);
            trangThaiLabel.Size = new Size(61, 20);
            trangThaiLabel.TabIndex = 4;
            trangThaiLabel.Text = "Trạng Thái";
            // 
            // luongTable
            // 
            luongTable.BackColor = Color.Transparent;
            luongTable.ColumnCount = 3;
            luongTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            luongTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            luongTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            luongTable.Controls.Add(tableLayoutPanel3, 2, 1);
            luongTable.Controls.Add(thongTinTable, 2, 0);
            luongTable.Controls.Add(chiTietLuongTable, 0, 0);
            luongTable.Controls.Add(tongLuongThucNhanTable, 0, 1);
            luongTable.Controls.Add(panel1, 1, 0);
            luongTable.Controls.Add(projectDataGridView, 0, 2);
            luongTable.Location = new Point(15, 71);
            luongTable.Name = "luongTable";
            luongTable.RowCount = 3;
            luongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 61.41079F));
            luongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.713693F));
            luongTable.RowStyles.Add(new RowStyle(SizeType.Percent, 29.6680489F));
            luongTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            luongTable.Size = new Size(1016, 482);
            luongTable.TabIndex = 5;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            ClientSize = new Size(1046, 565);
            Controls.Add(luongTable);
            Controls.Add(functionFlowPanel);
            Controls.Add(stripMenu);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = stripMenu;
            MaximizeBox = false;
            Name = "UserForm";
            Padding = new Padding(15, 0, 15, 0);
            Text = "Thông tin nhân viên";
            FormClosed += UserForm_FormClosed;
            Load += UserForm_Load;
            functionFlowPanel.ResumeLayout(false);
            stripMenu.ResumeLayout(false);
            stripMenu.PerformLayout();
            tongLuongThucNhanTable.ResumeLayout(false);
            tongLuongThucNhanTable.PerformLayout();
            chiTietLuongTable.ResumeLayout(false);
            chiTietLuongTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectDataGridView).EndInit();
            thongTinTable.ResumeLayout(false);
            thongTinTable.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            luongTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveButton;
        private Button deleteButton;
        private FlowLayoutPanel functionFlowPanel;
        private Button resetButton;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauStripMenuItem;
        private MenuStrip stripMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem lấyThôngTinNgườiĐầuTiênToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel luongTable;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox ngayThamGiaTextBox;
        private TextBox trangThaiTextBox;
        private Label ngayThamGiaLabel;
        private Label trangThaiLabel;
        private TableLayoutPanel thongTinTable;
        private Label gioiTinhLabel;
        private Label phongBanLabel;
        private Label chucVuLabel;
        private Label diaChiLabel;
        private Label sdtLabel;
        private Label emailLabel;
        private TextBox hoTenTextBox;
        private Label ngaySinhLabel;
        private Label hoTenLabel;
        private TextBox ngaySinhTextBox;
        private TextBox emailTextBox;
        private TextBox soDienThoaiTextBox;
        private TextBox diaChiTextBox;
        private TextBox chucVuTextBox;
        private TextBox phongBanTextBox;
        private ComboBox gioiTinhComboBox;
        private DataGridView projectDataGridView;
        private TableLayoutPanel chiTietLuongTable;
        private Label quyLabel;
        private Label luongCoBanLabel;
        private Label heSoLuong;
        private Label luongThuongLabel;
        private Label luongPhatLabel;
        private Label hienThiLuongLabel;
        private Label hienThiHSLuongLabel;
        private Label hienThiLuongThuongLabel;
        private Label hienThiLuongPhatLabel;
        private TableLayoutPanel tongLuongThucNhanTable;
        private Label tongLuongLabel;
        private Label tongLuongHienThiLabel;
        private ToolStripMenuItem iDNgườiĐăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }

}