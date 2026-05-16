namespace QuanLySinhVienWinForm.GUI
{
    partial class fSinhVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhoaToolStripMenuItem = new ToolStripMenuItem();
            quảnLýLớpToolStripMenuItem = new ToolStripMenuItem();
            quảnLýCốVấnHọcTậpToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMônHọcToolStripMenuItem = new ToolStripMenuItem();
            quánLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐiểmToolStripMenuItem = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            dgvSinhVien = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            cmbMaLop = new ComboBox();
            cmbMaCoVan = new ComboBox();
            cmbMaKhoa = new ComboBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            dtpkNhapHoc = new DateTimePicker();
            dtpkNgaySinh = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txbQueQuan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txbTenSV = new TextBox();
            txbMaSV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(46, 134, 193);
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1133, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýKhoaToolStripMenuItem, quảnLýLớpToolStripMenuItem, quảnLýCốVấnHọcTậpToolStripMenuItem, quảnLýMônHọcToolStripMenuItem, quánLýTàiKhoảnToolStripMenuItem, quảnLýĐiểmToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(91, 29);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click;
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            quảnLýKhoaToolStripMenuItem.Size = new Size(291, 30);
            quảnLýKhoaToolStripMenuItem.Text = "Quản lý khoa";
            quảnLýKhoaToolStripMenuItem.Click += quảnLýKhoaToolStripMenuItem_Click;
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            quảnLýLớpToolStripMenuItem.Size = new Size(291, 30);
            quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            quảnLýLớpToolStripMenuItem.Click += quảnLýLớpToolStripMenuItem_Click;
            // 
            // quảnLýCốVấnHọcTậpToolStripMenuItem
            // 
            quảnLýCốVấnHọcTậpToolStripMenuItem.Name = "quảnLýCốVấnHọcTậpToolStripMenuItem";
            quảnLýCốVấnHọcTậpToolStripMenuItem.Size = new Size(291, 30);
            quảnLýCốVấnHọcTậpToolStripMenuItem.Text = "Quản lý cố vấn học tập";
            quảnLýCốVấnHọcTậpToolStripMenuItem.Click += quảnLýCốVấnHọcTậpToolStripMenuItem_Click;
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            quảnLýMônHọcToolStripMenuItem.Size = new Size(291, 30);
            quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học";
            quảnLýMônHọcToolStripMenuItem.Click += quảnLýMônHọcToolStripMenuItem_Click;
            // 
            // quánLýTàiKhoảnToolStripMenuItem
            // 
            quánLýTàiKhoảnToolStripMenuItem.Name = "quánLýTàiKhoảnToolStripMenuItem";
            quánLýTàiKhoảnToolStripMenuItem.Size = new Size(291, 30);
            quánLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            quánLýTàiKhoảnToolStripMenuItem.Click += quánLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            quảnLýĐiểmToolStripMenuItem.Size = new Size(291, 30);
            quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            quảnLýĐiểmToolStripMenuItem.Click += quảnLýĐiểmToolStripMenuItem_Click;
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(108, 29);
            chứcNăngToolStripMenuItem.Text = "Tài Khoản";
            chứcNăngToolStripMenuItem.Click += chứcNăngToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(241, 30);
            thoátToolStripMenuItem.Text = "Thông tin chi tiết";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(241, 30);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(241, 30);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 134, 193);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dgvSinhVien.Dock = DockStyle.Bottom;
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.Location = new Point(0, 211);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 30;
            dgvSinhVien.Size = new Size(1133, 245);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            dgvSinhVien.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaSV";
            Column2.HeaderText = "Mã Sinh Viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenSV";
            Column3.HeaderText = "Tên Sinh Viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 145;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "NgaySinh";
            Column4.HeaderText = "Ngày Sinh";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "GioiTinh";
            Column5.HeaderText = "Giới Tính";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "QueQuan";
            Column6.HeaderText = "Quê Quán";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "NgayNhapHoc";
            Column7.HeaderText = "Nhập Học";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "MaLop";
            Column8.HeaderText = "Mã Lớp";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "MaKhoa";
            Column9.HeaderText = "Mã Khoa";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "MaCVHT";
            Column10.HeaderText = "Mã Cố Vấn";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 120;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(235, 245, 251);
            panel2.Controls.Add(cmbMaLop);
            panel2.Controls.Add(cmbMaCoVan);
            panel2.Controls.Add(cmbMaKhoa);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(rdNu);
            panel2.Controls.Add(rdNam);
            panel2.Controls.Add(dtpkNhapHoc);
            panel2.Controls.Add(dtpkNgaySinh);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbQueQuan);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txbTenSV);
            panel2.Controls.Add(txbMaSV);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbID);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 11F);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1133, 211);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // cmbMaLop
            // 
            cmbMaLop.FormattingEnabled = true;
            cmbMaLop.Location = new Point(953, 59);
            cmbMaLop.Name = "cmbMaLop";
            cmbMaLop.Size = new Size(101, 33);
            cmbMaLop.TabIndex = 25;
            cmbMaLop.SelectedIndexChanged += cmbMaLop_SelectedIndexChanged;
            // 
            // cmbMaCoVan
            // 
            cmbMaCoVan.FormattingEnabled = true;
            cmbMaCoVan.Location = new Point(374, 115);
            cmbMaCoVan.Name = "cmbMaCoVan";
            cmbMaCoVan.Size = new Size(163, 33);
            cmbMaCoVan.TabIndex = 24;
            cmbMaCoVan.SelectedIndexChanged += cmbMaCoVan_SelectedIndexChanged;
            // 
            // cmbMaKhoa
            // 
            cmbMaKhoa.FormattingEnabled = true;
            cmbMaKhoa.Location = new Point(110, 115);
            cmbMaKhoa.Name = "cmbMaKhoa";
            cmbMaKhoa.Size = new Size(121, 33);
            cmbMaKhoa.TabIndex = 23;
            cmbMaKhoa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(868, 115);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(108, 40);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.TabStop = false;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(771, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 40);
            btnXoa.TabIndex = 21;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(678, 115);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 40);
            btnSua.TabIndex = 20;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(583, 115);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 40);
            btnThem.TabIndex = 19;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(189, 62);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(58, 29);
            rdNu.TabIndex = 4;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(110, 62);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(73, 29);
            rdNam.TabIndex = 4;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            rdNam.CheckedChanged += rdNam_CheckedChanged;
            // 
            // dtpkNhapHoc
            // 
            dtpkNhapHoc.Format = DateTimePickerFormat.Short;
            dtpkNhapHoc.Location = new Point(718, 58);
            dtpkNhapHoc.Name = "dtpkNhapHoc";
            dtpkNhapHoc.Size = new Size(128, 32);
            dtpkNhapHoc.TabIndex = 6;
            dtpkNhapHoc.Value = new DateTime(2022, 10, 10, 11, 34, 0, 0);
            dtpkNhapHoc.ValueChanged += dtpkNhapHoc_ValueChanged;
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Format = DateTimePickerFormat.Short;
            dtpkNgaySinh.Location = new Point(786, 7);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(129, 32);
            dtpkNgaySinh.TabIndex = 3;
            dtpkNgaySinh.Value = new DateTime(2004, 9, 12, 11, 34, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(254, 123);
            label10.Name = "label10";
            label10.Size = new Size(114, 25);
            label10.TabIndex = 18;
            label10.Text = "Mã Cố Vấn: ";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 123);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 16;
            label9.Text = "Mã Khóa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(868, 62);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 14;
            label8.Text = "Mã Lớp:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(607, 62);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 12;
            label7.Text = "Nhập Học: ";
            label7.Click += label7_Click;
            // 
            // txbQueQuan
            // 
            txbQueQuan.Location = new Point(394, 56);
            txbQueQuan.MaxLength = 255;
            txbQueQuan.Name = "txbQueQuan";
            txbQueQuan.Size = new Size(194, 32);
            txbQueQuan.TabIndex = 5;
            txbQueQuan.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 63);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 10;
            label6.Text = "Quê Quán:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 62);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 8;
            label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(678, 11);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 6;
            label4.Text = "Ngày Sinh:";
            label4.Click += label4_Click;
            // 
            // txbTenSV
            // 
            txbTenSV.Location = new Point(374, 7);
            txbTenSV.MaxLength = 255;
            txbTenSV.Name = "txbTenSV";
            txbTenSV.Size = new Size(273, 32);
            txbTenSV.TabIndex = 2;
            txbTenSV.TextChanged += textBox3_TextChanged;
            // 
            // txbMaSV
            // 
            txbMaSV.Location = new Point(171, 7);
            txbMaSV.MaxLength = 255;
            txbMaSV.Name = "txbMaSV";
            txbMaSV.Size = new Size(105, 32);
            txbMaSV.TabIndex = 1;
            txbMaSV.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 11);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 3;
            label3.Text = "Mã SV:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 10);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên SV:";
            label2.Click += label2_Click;
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(46, 7);
            txbID.Name = "txbID";
            txbID.Size = new Size(47, 32);
            txbID.TabIndex = 0;
            txbID.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvSinhVien);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 456);
            panel1.TabIndex = 1;
            // 
            // fSinhVien
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1133, 489);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "fSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            WindowState = FormWindowState.Maximized;
            Load += fSinhVien_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private DataGridView dgvSinhVien;
        private Panel panel2;
        private TextBox txbTenSV;
        private TextBox txbMaSV;
        private Label label3;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox txbQueQuan;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private DateTimePicker dtpkNhapHoc;
        private DateTimePicker dtpkNgaySinh;
        private Label label10;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private ToolStripMenuItem quảnLýCốVấnHọcTậpToolStripMenuItem;
        private ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private ToolStripMenuItem quánLýTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
        private ComboBox cmbMaLop;
        private ComboBox cmbMaCoVan;
        private ComboBox cmbMaKhoa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}