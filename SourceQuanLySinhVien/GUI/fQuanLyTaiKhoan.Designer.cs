namespace BaiTapLon.GUI
{
    partial class fQuanLyTaiKhoan
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
            panel1 = new Panel();
            cmbLoaiTaiKhoan = new ComboBox();
            txbLoai = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txbMatKhau = new TextBox();
            label3 = new Label();
            txbTenDangNhap = new TextBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvTaiKhoan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbLoaiTaiKhoan);
            panel1.Controls.Add(txbLoai);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txbMatKhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbTenDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 118);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cmbLoaiTaiKhoan
            // 
            cmbLoaiTaiKhoan.FormattingEnabled = true;
            cmbLoaiTaiKhoan.Items.AddRange(new object[] { "Cố Vấn Học Tập", "Quản Trị " });
            cmbLoaiTaiKhoan.Location = new Point(312, 40);
            cmbLoaiTaiKhoan.Name = "cmbLoaiTaiKhoan";
            cmbLoaiTaiKhoan.Size = new Size(153, 27);
            cmbLoaiTaiKhoan.TabIndex = 11;
            // 
            // txbLoai
            // 
            txbLoai.AutoSize = true;
            txbLoai.Location = new Point(263, 44);
            txbLoai.Name = "txbLoai";
            txbLoai.Size = new Size(43, 19);
            txbLoai.TabIndex = 10;
            txbLoai.Text = "Loại: ";
            txbLoai.Click += txbLoai_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(383, 79);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(277, 79);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button3_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(170, 79);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(66, 79);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(126, 40);
            txbMatKhau.MaxLength = 255;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(131, 26);
            txbMatKhau.TabIndex = 5;
            txbMatKhau.TextChanged += txbMatKhau_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 44);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 4;
            label3.Text = "Mật Khẩu:";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(204, 8);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(313, 26);
            txbTenDangNhap.TabIndex = 3;
            txbTenDangNhap.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 11);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 2;
            label2.Text = "Tên Đăng Nhập:";
            label2.Click += label2_Click;
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(46, 8);
            txbID.Name = "txbID";
            txbID.Size = new Size(37, 26);
            txbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 303);
            panel2.TabIndex = 1;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowTemplate.Height = 30;
            dgvTaiKhoan.Size = new Size(529, 303);
            dgvTaiKhoan.TabIndex = 1;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            dgvTaiKhoan.CellContentClick += dgvSinhVien_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenDangNhap";
            Column2.HeaderText = "Tên Đăng Nhập";
            Column2.Name = "Column2";
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MatKhau";
            Column3.HeaderText = "Mật Khẩu";
            Column3.Name = "Column3";
            Column3.Width = 160;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "LoaiTaiKhoan";
            Column4.HeaderText = "Loại Tài Khoản";
            Column4.Name = "Column4";
            Column4.Width = 160;
            // 
            // fQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 421);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fQuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvTaiKhoan;
        private TextBox txbTenDangNhap;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txbMatKhau;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cmbLoaiTaiKhoan;
        private Label txbLoai;
    }
}