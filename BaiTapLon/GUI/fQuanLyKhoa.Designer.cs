namespace BaiTapLon.GUI
{
    partial class fQuanLyKhoa
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
            dgvKhoa = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txbTenKhoa = new TextBox();
            label3 = new Label();
            txbMaKhoa = new TextBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvKhoa);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 381);
            panel2.TabIndex = 3;
            // 
            // dgvKhoa
            // 
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.AllowUserToDeleteRows = false;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvKhoa.Dock = DockStyle.Fill;
            dgvKhoa.Location = new Point(0, 0);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersVisible = false;
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.RowTemplate.Height = 30;
            dgvKhoa.Size = new Size(531, 381);
            dgvKhoa.TabIndex = 1;
            dgvKhoa.CellClick += dgvKhoa_CellClick_1;
            dgvKhoa.Click += dgvKhoa_Click;
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
            Column2.DataPropertyName = "Makhoa";
            Column2.HeaderText = "Mã Khoa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenKhoa";
            Column3.HeaderText = "Tên Khoa";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 230;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txbTenKhoa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaKhoa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 82);
            panel1.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(354, 44);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 32);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(273, 44);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 32);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(190, 44);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 32);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(108, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 32);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbTenKhoa
            // 
            txbTenKhoa.Location = new Point(334, 3);
            txbTenKhoa.MaxLength = 255;
            txbTenKhoa.Name = "txbTenKhoa";
            txbTenKhoa.Size = new Size(189, 26);
            txbTenKhoa.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 7);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 4;
            label3.Text = "Tên Khoa:";
            // 
            // txbMaKhoa
            // 
            txbMaKhoa.Location = new Point(157, 3);
            txbMaKhoa.MaxLength = 255;
            txbMaKhoa.Name = "txbMaKhoa";
            txbMaKhoa.Size = new Size(96, 26);
            txbMaKhoa.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 7);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Mã Khoa:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(37, 3);
            txbID.Name = "txbID";
            txbID.Size = new Size(37, 26);
            txbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // fQuanLyKhoa
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 463);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fQuanLyKhoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khoa";
            Load += fQuanLyKhoa_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvKhoa;
        private Panel panel1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txbTenKhoa;
        private Label label3;
        private TextBox txbMaKhoa;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}