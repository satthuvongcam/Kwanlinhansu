namespace quanlihosonhansu.User__things
{
    partial class DoiMatKhau
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            nhapLaiTextBox = new TextBox();
            matKhauMoiTextBox = new TextBox();
            matKhauCuTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            doiMatKhauButton = new Button();
            reminderLable = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.1269836F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.8730164F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(353, 252);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1037493F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.8962555F));
            tableLayoutPanel2.Controls.Add(nhapLaiTextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(matKhauMoiTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(matKhauCuTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox3, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.733728F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.31056F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.3602486F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.3602486F));
            tableLayoutPanel2.Size = new Size(347, 143);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // nhapLaiTextBox
            // 
            nhapLaiTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nhapLaiTextBox.Location = new Point(45, 117);
            nhapLaiTextBox.Name = "nhapLaiTextBox";
            nhapLaiTextBox.PasswordChar = '*';
            nhapLaiTextBox.PlaceholderText = "Nhập lại mật khẩu mới";
            nhapLaiTextBox.Size = new Size(272, 23);
            nhapLaiTextBox.TabIndex = 5;
            nhapLaiTextBox.TextChanged += nhapLaiTextBox_TextChanged;
            // 
            // matKhauMoiTextBox
            // 
            matKhauMoiTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            matKhauMoiTextBox.Location = new Point(45, 84);
            matKhauMoiTextBox.Name = "matKhauMoiTextBox";
            matKhauMoiTextBox.PasswordChar = '*';
            matKhauMoiTextBox.PlaceholderText = "Nhập mật khẩu mới";
            matKhauMoiTextBox.Size = new Size(272, 23);
            matKhauMoiTextBox.TabIndex = 4;
            // 
            // matKhauCuTextBox
            // 
            matKhauCuTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            matKhauCuTextBox.Location = new Point(45, 52);
            matKhauCuTextBox.Name = "matKhauCuTextBox";
            matKhauCuTextBox.PasswordChar = '*';
            matKhauCuTextBox.PlaceholderText = "Nhập mật khẩu cũ";
            matKhauCuTextBox.Size = new Size(272, 23);
            matKhauCuTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.key;
            pictureBox1.Location = new Point(21, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 16);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.key;
            pictureBox2.Location = new Point(21, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 16);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.key;
            pictureBox3.Location = new Point(21, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 16);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(doiMatKhauButton);
            panel1.Controls.Add(reminderLable);
            panel1.Location = new Point(3, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 75);
            panel1.TabIndex = 1;
            // 
            // doiMatKhauButton
            // 
            doiMatKhauButton.BackColor = Color.FromArgb(224, 224, 224);
            doiMatKhauButton.FlatStyle = FlatStyle.Flat;
            doiMatKhauButton.ForeColor = Color.Black;
            doiMatKhauButton.Location = new Point(45, 33);
            doiMatKhauButton.Name = "doiMatKhauButton";
            doiMatKhauButton.Size = new Size(146, 23);
            doiMatKhauButton.TabIndex = 1;
            doiMatKhauButton.Text = "Đổi Mật Khẩu";
            doiMatKhauButton.UseVisualStyleBackColor = false;
            doiMatKhauButton.Click += doiMatKhauButton_Click;
            // 
            // reminderLable
            // 
            reminderLable.AutoSize = true;
            reminderLable.ForeColor = Color.OrangeRed;
            reminderLable.Location = new Point(45, -3);
            reminderLable.Name = "reminderLable";
            reminderLable.Size = new Size(175, 15);
            reminderLable.TabIndex = 0;
            reminderLable.Text = "Mật khẩu nhập lại không khớp !";
            reminderLable.Visible = false;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 264);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DoiMatKhau";
            Text = "Đổi Mật Khẩu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private TextBox matKhauCuTextBox;
        private TextBox matKhauMoiTextBox;
        private TextBox nhapLaiTextBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button doiMatKhauButton;
        private Label reminderLable;
    }
}