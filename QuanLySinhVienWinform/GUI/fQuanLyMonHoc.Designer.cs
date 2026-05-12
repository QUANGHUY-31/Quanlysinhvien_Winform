namespace QuanLySinhVienWinForm.GUI
{
    partial class fQuanLyMonHoc
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
            numTietLyThuyet = new NumericUpDown();
            numTietThucHanh = new NumericUpDown();
            numSoTinChi = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txbTenMonHoc = new TextBox();
            label3 = new Label();
            txbMaMonHoc = new TextBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvQuanLyMonHoc = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTietLyThuyet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTietThucHanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyMonHoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numTietLyThuyet);
            panel1.Controls.Add(numTietThucHanh);
            panel1.Controls.Add(numSoTinChi);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txbTenMonHoc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaMonHoc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 124);
            panel1.TabIndex = 0;
            // 
            // numTietLyThuyet
            // 
            numTietLyThuyet.Location = new Point(573, 42);
            numTietLyThuyet.Name = "numTietLyThuyet";
            numTietLyThuyet.Size = new Size(55, 26);
            numTietLyThuyet.TabIndex = 5;
            // 
            // numTietThucHanh
            // 
            numTietThucHanh.Location = new Point(406, 42);
            numTietThucHanh.Name = "numTietThucHanh";
            numTietThucHanh.Size = new Size(56, 26);
            numTietThucHanh.TabIndex = 4;
            // 
            // numSoTinChi
            // 
            numSoTinChi.Location = new Point(225, 42);
            numSoTinChi.Name = "numSoTinChi";
            numSoTinChi.Size = new Size(59, 26);
            numSoTinChi.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1385, 29);
            numericUpDown1.Margin = new Padding(6);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(114, 26);
            numericUpDown1.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 46);
            label7.Name = "label7";
            label7.Size = new Size(99, 19);
            label7.TabIndex = 40;
            label7.Text = "Tiết Lý Thuyết:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 46);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 38;
            label4.Text = "Số Tín Chỉ:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 46);
            label5.Name = "label5";
            label5.Size = new Size(106, 19);
            label5.TabIndex = 37;
            label5.Text = "Tiết Thực Hành:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(468, 83);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 36;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(387, 83);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 35);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(306, 83);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 35);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(225, 83);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 35);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbTenMonHoc
            // 
            txbTenMonHoc.Location = new Point(410, 7);
            txbTenMonHoc.MaxLength = 255;
            txbTenMonHoc.Name = "txbTenMonHoc";
            txbTenMonHoc.Size = new Size(341, 26);
            txbTenMonHoc.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 11);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 29;
            label3.Text = "Tên Môn Học:";
            // 
            // txbMaMonHoc
            // 
            txbMaMonHoc.Location = new Point(185, 8);
            txbMaMonHoc.MaxLength = 255;
            txbMaMonHoc.Name = "txbMaMonHoc";
            txbMaMonHoc.Size = new Size(102, 26);
            txbMaMonHoc.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 11);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 24;
            label2.Text = "Mã Môn Học:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(40, 7);
            txbID.Name = "txbID";
            txbID.Size = new Size(37, 26);
            txbID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 22;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvQuanLyMonHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 395);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dgvQuanLyMonHoc
            // 
            dgvQuanLyMonHoc.AllowUserToAddRows = false;
            dgvQuanLyMonHoc.AllowUserToDeleteRows = false;
            dgvQuanLyMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyMonHoc.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvQuanLyMonHoc.Dock = DockStyle.Fill;
            dgvQuanLyMonHoc.Location = new Point(0, 0);
            dgvQuanLyMonHoc.Name = "dgvQuanLyMonHoc";
            dgvQuanLyMonHoc.RowHeadersVisible = false;
            dgvQuanLyMonHoc.RowHeadersWidth = 51;
            dgvQuanLyMonHoc.RowTemplate.Height = 30;
            dgvQuanLyMonHoc.Size = new Size(782, 395);
            dgvQuanLyMonHoc.TabIndex = 2;
            dgvQuanLyMonHoc.CellClick += dgvQuanLyMonHoc_CellClick;
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
            Column2.DataPropertyName = "MaMH";
            Column2.HeaderText = "Mã Môn Học";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenMH";
            Column3.HeaderText = "Tên Môn Học";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SoTC";
            Column4.HeaderText = "Số Tín Chỉ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TietLT";
            Column5.HeaderText = "T.Lý Thuyết";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 145;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "TietTH";
            Column6.HeaderText = "T.Thực Hành";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 145;
            // 
            // fQuanLyMonHoc
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fQuanLyMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Môn Học";
            Load += fQuanLyMonHoc_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTietLyThuyet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTietThucHanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyMonHoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label4;
        private Label label5;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txbTenMonHoc;
        private Label label3;
        private TextBox txbMaMonHoc;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private DataGridView dgvQuanLyMonHoc;
        private NumericUpDown numSoTinChi;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numTietLyThuyet;
        private NumericUpDown numTietThucHanh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}