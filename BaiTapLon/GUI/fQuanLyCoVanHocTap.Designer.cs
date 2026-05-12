namespace BaiTapLon.GUI
{
    partial class fQuanLyCoVanHocTap
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
            panel2 = new Panel();
            dgvQuanLyCoVanHocTap = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            cmbMaLop = new ComboBox();
            label7 = new Label();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            label6 = new Label();
            dtpkNgaySinh = new DateTimePicker();
            label4 = new Label();
            cmbMaKhoa = new ComboBox();
            label5 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txbTenCoVan = new TextBox();
            label3 = new Label();
            txbMaCoVan = new TextBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyCoVanHocTap).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvQuanLyCoVanHocTap);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 408);
            panel2.TabIndex = 7;
            // 
            // dgvQuanLyCoVanHocTap
            // 
            dgvQuanLyCoVanHocTap.AllowUserToAddRows = false;
            dgvQuanLyCoVanHocTap.AllowUserToDeleteRows = false;
            dgvQuanLyCoVanHocTap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyCoVanHocTap.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvQuanLyCoVanHocTap.Dock = DockStyle.Fill;
            dgvQuanLyCoVanHocTap.Location = new Point(0, 0);
            dgvQuanLyCoVanHocTap.Name = "dgvQuanLyCoVanHocTap";
            dgvQuanLyCoVanHocTap.RowHeadersVisible = false;
            dgvQuanLyCoVanHocTap.RowHeadersWidth = 51;
            dgvQuanLyCoVanHocTap.RowTemplate.Height = 30;
            dgvQuanLyCoVanHocTap.Size = new Size(865, 408);
            dgvQuanLyCoVanHocTap.TabIndex = 1;
            dgvQuanLyCoVanHocTap.CellClick += dgvQuanLyCoVanHocTap_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaCVHT";
            Column2.HeaderText = "Mã CVHT";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenCVHT";
            Column3.HeaderText = "Tên Cố Vấn";
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
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "GioiTinh";
            Column5.HeaderText = "Giới Tính";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "MaLop";
            Column6.HeaderText = "Mã Lớp";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "MaKhoa";
            Column7.HeaderText = "Mã Khoa";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbMaLop);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(rdNu);
            panel1.Controls.Add(rdNam);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpkNgaySinh);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbMaKhoa);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txbTenCoVan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaCoVan);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 125);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // cmbMaLop
            // 
            cmbMaLop.FormattingEnabled = true;
            cmbMaLop.Location = new Point(373, 41);
            cmbMaLop.Name = "cmbMaLop";
            cmbMaLop.Size = new Size(133, 27);
            cmbMaLop.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 44);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 21;
            label7.Text = "Mã Lớp:";
            label7.Click += label7_Click;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(187, 42);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(48, 23);
            rdNu.TabIndex = 5;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(113, 42);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(57, 23);
            rdNam.TabIndex = 4;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            rdNam.CheckedChanged += rdNam_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 47);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 19;
            label6.Text = "Giới Tính:";
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Format = DateTimePickerFormat.Short;
            dtpkNgaySinh.Location = new Point(724, 7);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(100, 26);
            dtpkNgaySinh.TabIndex = 3;
            dtpkNgaySinh.Value = new DateTime(2004, 9, 12, 11, 34, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 9);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 16;
            label4.Text = "Ngày Sinh:";
            // 
            // cmbMaKhoa
            // 
            cmbMaKhoa.FormattingEnabled = true;
            cmbMaKhoa.Location = new Point(624, 41);
            cmbMaKhoa.Name = "cmbMaKhoa";
            cmbMaKhoa.Size = new Size(139, 27);
            cmbMaKhoa.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 49);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 13;
            label5.Text = "Mã Khoa:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(500, 77);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 28);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(419, 77);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 28);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(338, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 28);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(257, 77);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 28);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbTenCoVan
            // 
            txbTenCoVan.Location = new Point(428, 6);
            txbTenCoVan.MaxLength = 255;
            txbTenCoVan.Name = "txbTenCoVan";
            txbTenCoVan.Size = new Size(178, 26);
            txbTenCoVan.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 4;
            label3.Text = "Tên Cố Vấn:";
            // 
            // txbMaCoVan
            // 
            txbMaCoVan.Location = new Point(203, 6);
            txbMaCoVan.MaxLength = 255;
            txbMaCoVan.Name = "txbMaCoVan";
            txbMaCoVan.Size = new Size(102, 26);
            txbMaCoVan.TabIndex = 2;
            txbMaCoVan.TextChanged += txbMaCoVan_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 11);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 2;
            label2.Text = "Mã Cố Vấn:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(43, 7);
            txbID.Name = "txbID";
            txbID.Size = new Size(37, 26);
            txbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // fQuanLyCoVanHocTap
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fQuanLyCoVanHocTap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Cố Vấn Học Tập";
            Load += fQuanLyCoVanHocTap_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyCoVanHocTap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvQuanLyCoVanHocTap;
        private Panel panel1;
        private ComboBox cmbMaKhoa;
        private Label label5;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txbTenCoVan;
        private Label label3;
        private TextBox txbMaCoVan;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private DateTimePicker dtpkNgaySinh;
        private Label label4;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label label6;
        private Label label7;
        private ComboBox cmbMaLop;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}