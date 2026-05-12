namespace BaiTapLon.GUI
{
    partial class fQuanLyLop
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
            dgvLop = new DataGridView();
            panel1 = new Panel();
            cmbMaKhoa = new ComboBox();
            label5 = new Label();
            numSoLuong = new NumericUpDown();
            label4 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txbTenLop = new TextBox();
            label3 = new Label();
            txbMaLop = new TextBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvLop);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 369);
            panel2.TabIndex = 5;
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvLop.Dock = DockStyle.Fill;
            dgvLop.Location = new Point(0, 0);
            dgvLop.Name = "dgvLop";
            dgvLop.RowHeadersVisible = false;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.RowTemplate.Height = 30;
            dgvLop.Size = new Size(701, 369);
            dgvLop.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbMaKhoa);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numSoLuong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txbTenLop);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaLop);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 82);
            panel1.TabIndex = 4;
            // 
            // cmbMaKhoa
            // 
            cmbMaKhoa.FormattingEnabled = true;
            cmbMaKhoa.Location = new Point(107, 42);
            cmbMaKhoa.Name = "cmbMaKhoa";
            cmbMaKhoa.Size = new Size(119, 27);
            cmbMaKhoa.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 47);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 13;
            label5.Text = "Mã Khoa:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(597, 6);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(59, 26);
            numSoLuong.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 10);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 10;
            label4.Text = "Số Lượng:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(480, 47);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(95, 31);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(399, 47);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 31);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(318, 47);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(73, 31);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(237, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(73, 31);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbTenLop
            // 
            txbTenLop.Location = new Point(333, 7);
            txbTenLop.MaxLength = 255;
            txbTenLop.Name = "txbTenLop";
            txbTenLop.Size = new Size(179, 26);
            txbTenLop.TabIndex = 3;
            txbTenLop.TextChanged += txbTenLop_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 11);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 4;
            label3.Text = "Tên Lớp:";
            // 
            // txbMaLop
            // 
            txbMaLop.Location = new Point(148, 6);
            txbMaLop.MaxLength = 255;
            txbMaLop.Name = "txbMaLop";
            txbMaLop.Size = new Size(109, 26);
            txbMaLop.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 11);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "Mã Lớp:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(37, 7);
            txbID.Name = "txbID";
            txbID.Size = new Size(37, 26);
            txbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
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
            Column2.DataPropertyName = "Malop";
            Column2.HeaderText = "Mã Lớp";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenLop";
            Column3.HeaderText = "Tên Lớp";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 160;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SoLuong";
            Column4.HeaderText = "Số Lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MaKhoa";
            Column5.HeaderText = "Mã Khoa";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // fQuanLyLop
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 451);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fQuanLyLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Lớp";
            Load += fQuanLyLop_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvLop;
        private Panel panel1;
        private Label label4;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txbTenLop;
        private Label label3;
        private TextBox txbMaLop;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private NumericUpDown numSoLuong;
        private ComboBox cmbMaKhoa;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}