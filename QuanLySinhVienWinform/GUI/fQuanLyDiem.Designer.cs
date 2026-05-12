namespace QuanLySinhVienWinForm.GUI
{
    partial class fQuanLyDiem
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
            txbDiemTB = new TextBox();
            txbDiemThi = new TextBox();
            txbDiemLop = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cmbLoai = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            numPhanTramThi = new NumericUpDown();
            label5 = new Label();
            numPhanTramLop = new NumericUpDown();
            label4 = new Label();
            cmbMaMonHoc = new ComboBox();
            label3 = new Label();
            cmbMaSinhVien = new ComboBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvDiem = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPhanTramThi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhanTramLop).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDiemTB);
            panel1.Controls.Add(txbDiemThi);
            panel1.Controls.Add(txbDiemLop);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(cmbLoai);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numPhanTramThi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numPhanTramLop);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbMaMonHoc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbMaSinhVien);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 122);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txbDiemTB
            // 
            txbDiemTB.Location = new Point(563, 49);
            txbDiemTB.Name = "txbDiemTB";
            txbDiemTB.Size = new Size(54, 26);
            txbDiemTB.TabIndex = 29;
            // 
            // txbDiemThi
            // 
            txbDiemThi.Location = new Point(430, 49);
            txbDiemThi.Name = "txbDiemThi";
            txbDiemThi.Size = new Size(54, 26);
            txbDiemThi.TabIndex = 28;
            // 
            // txbDiemLop
            // 
            txbDiemLop.Location = new Point(297, 49);
            txbDiemLop.Name = "txbDiemLop";
            txbDiemLop.Size = new Size(54, 26);
            txbDiemLop.TabIndex = 27;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(500, 92);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 26;
            btnLamMoi.TabStop = false;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(419, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 25;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(338, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 24;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(257, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 23;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cmbLoai
            // 
            cmbLoai.FormattingEnabled = true;
            cmbLoai.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            cmbLoai.Location = new Point(665, 49);
            cmbLoai.Name = "cmbLoai";
            cmbLoai.Size = new Size(52, 27);
            cmbLoai.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(623, 56);
            label9.Name = "label9";
            label9.Size = new Size(36, 19);
            label9.TabIndex = 17;
            label9.Text = "Loại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(490, 56);
            label8.Name = "label8";
            label8.Size = new Size(67, 19);
            label8.TabIndex = 15;
            label8.Text = "Điểm TB:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 56);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 13;
            label7.Text = "Điểm Thi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 56);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 11;
            label6.Text = "Điểm Lớp:";
            // 
            // numPhanTramThi
            // 
            numPhanTramThi.Location = new Point(158, 52);
            numPhanTramThi.Name = "numPhanTramThi";
            numPhanTramThi.Size = new Size(54, 26);
            numPhanTramThi.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 56);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 9;
            label5.Text = "P.Trăm Thi:";
            label5.Click += label5_Click;
            // 
            // numPhanTramLop
            // 
            numPhanTramLop.Location = new Point(722, 8);
            numPhanTramLop.Name = "numPhanTramLop";
            numPhanTramLop.Size = new Size(54, 26);
            numPhanTramLop.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(623, 12);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 7;
            label4.Text = "P.Trăm Lớp:";
            // 
            // cmbMaMonHoc
            // 
            cmbMaMonHoc.FormattingEnabled = true;
            cmbMaMonHoc.Location = new Point(481, 8);
            cmbMaMonHoc.MaxLength = 255;
            cmbMaMonHoc.Name = "cmbMaMonHoc";
            cmbMaMonHoc.Size = new Size(136, 27);
            cmbMaMonHoc.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 12);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 5;
            label3.Text = "Mã Môn Học:";
            // 
            // cmbMaSinhVien
            // 
            cmbMaSinhVien.FormattingEnabled = true;
            cmbMaSinhVien.Location = new Point(252, 8);
            cmbMaSinhVien.MaxLength = 255;
            cmbMaSinhVien.Name = "cmbMaSinhVien";
            cmbMaSinhVien.Size = new Size(128, 27);
            cmbMaSinhVien.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 12);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 3;
            label2.Text = "Mã Sinh Viên:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(105, 8);
            txbID.Name = "txbID";
            txbID.Size = new Size(47, 26);
            txbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 12);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDiem);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 382);
            panel2.TabIndex = 1;
            // 
            // dgvDiem
            // 
            dgvDiem.AllowUserToAddRows = false;
            dgvDiem.AllowUserToDeleteRows = false;
            dgvDiem.AllowUserToResizeRows = false;
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvDiem.Dock = DockStyle.Fill;
            dgvDiem.Location = new Point(0, 0);
            dgvDiem.MultiSelect = false;
            dgvDiem.Name = "dgvDiem";
            dgvDiem.RowHeadersVisible = false;
            dgvDiem.RowTemplate.Height = 30;
            dgvDiem.Size = new Size(865, 382);
            dgvDiem.TabIndex = 1;
            dgvDiem.CellClick += dgvDiem_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaSV";
            Column2.HeaderText = "Mã Sinh Viên";
            Column2.Name = "Column2";
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MaMH";
            Column3.HeaderText = "Mã Môn Hoc";
            Column3.Name = "Column3";
            Column3.Width = 145;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PhanTramTrenLop";
            Column4.HeaderText = "P.Trăm Lớp";
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PhanTramThi";
            Column5.HeaderText = "P.Trăm Thi";
            Column5.Name = "Column5";
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DiemTrenLop";
            Column6.HeaderText = "Điểm Lớp";
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "DiemThi";
            Column7.HeaderText = "Điểm Thi";
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "DiemTB";
            Column8.HeaderText = "Điểm TB";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Loai";
            Column9.HeaderText = "Loại";
            Column9.Name = "Column9";
            // 
            // fQuanLyDiem
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 504);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fQuanLyDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Điểm";
            Load += fQuanLyDiem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPhanTramThi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhanTramLop).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDiem;
        private TextBox txbID;
        private Label label1;
        private NumericUpDown numPhanTramThi;
        private Label label5;
        private NumericUpDown numPhanTramLop;
        private Label label4;
        private ComboBox cmbMaMonHoc;
        private Label label3;
        private ComboBox cmbMaSinhVien;
        private Label label2;
        private Label label6;
        private ComboBox cmbLoai;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txbDiemTB;
        private TextBox txbDiemThi;
        private TextBox txbDiemLop;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}