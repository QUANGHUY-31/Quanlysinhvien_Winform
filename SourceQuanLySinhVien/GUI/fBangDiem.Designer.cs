namespace BaiTapLon.GUI
{
    partial class fBangDiem
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
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            txbLoai = new TextBox();
            txbMaMonHoc = new TextBox();
            txbMaSinhVien = new TextBox();
            txbDiemTB = new TextBox();
            txbDiemThi = new TextBox();
            txbDiemLop = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.Location = new Point(0, 0);
            dgvSinhVien.Margin = new Padding(2, 3, 2, 3);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 30;
            dgvSinhVien.Size = new Size(913, 443);
            dgvSinhVien.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã Sinh Viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã Môn Hoc";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 145;
            // 
            // Column4
            // 
            Column4.HeaderText = "P.Trăm Lớp";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "P.Trăm Thi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.HeaderText = "Điểm Lớp";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.HeaderText = "Điểm Thi";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Điểm TB";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Loại";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(465, 56);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(41, 23);
            label9.TabIndex = 17;
            label9.Text = "Loại";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(84, 52);
            numericUpDown2.Margin = new Padding(2, 3, 2, 3);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(44, 30);
            numericUpDown2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 56);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 9;
            label5.Text = "P.Trăm Thi:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(538, 9);
            numericUpDown1.Margin = new Padding(2, 3, 2, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 30);
            numericUpDown1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 7;
            label4.Text = "P.Trăm Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 5;
            label3.Text = "Mã Môn Học:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 3;
            label2.Text = "Mã Sinh Viên:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(41, 9);
            txbID.Margin = new Padding(2, 3, 2, 3);
            txbID.Name = "txbID";
            txbID.Size = new Size(39, 30);
            txbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvSinhVien);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 91);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 443);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbLoai);
            panel1.Controls.Add(txbMaMonHoc);
            panel1.Controls.Add(txbMaSinhVien);
            panel1.Controls.Add(txbDiemTB);
            panel1.Controls.Add(txbDiemThi);
            panel1.Controls.Add(txbDiemLop);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 91);
            panel1.TabIndex = 2;
            // 
            // txbLoai
            // 
            txbLoai.Location = new Point(499, 51);
            txbLoai.Margin = new Padding(2, 3, 2, 3);
            txbLoai.Name = "txbLoai";
            txbLoai.Size = new Size(45, 30);
            txbLoai.TabIndex = 38;
            // 
            // txbMaMonHoc
            // 
            txbMaMonHoc.Location = new Point(354, 9);
            txbMaMonHoc.Margin = new Padding(2, 3, 2, 3);
            txbMaMonHoc.Name = "txbMaMonHoc";
            txbMaMonHoc.Size = new Size(106, 30);
            txbMaMonHoc.TabIndex = 37;
            // 
            // txbMaSinhVien
            // 
            txbMaSinhVien.Location = new Point(165, 8);
            txbMaSinhVien.Margin = new Padding(2, 3, 2, 3);
            txbMaSinhVien.Name = "txbMaSinhVien";
            txbMaSinhVien.Size = new Size(101, 30);
            txbMaSinhVien.TabIndex = 36;
            // 
            // txbDiemTB
            // 
            txbDiemTB.Location = new Point(416, 52);
            txbDiemTB.Margin = new Padding(2, 3, 2, 3);
            txbDiemTB.Name = "txbDiemTB";
            txbDiemTB.Size = new Size(45, 30);
            txbDiemTB.TabIndex = 35;
            // 
            // txbDiemThi
            // 
            txbDiemThi.Location = new Point(307, 52);
            txbDiemThi.Margin = new Padding(2, 3, 2, 3);
            txbDiemThi.Name = "txbDiemThi";
            txbDiemThi.Size = new Size(45, 30);
            txbDiemThi.TabIndex = 34;
            txbDiemThi.TextChanged += txbDiemThi_TextChanged;
            // 
            // txbDiemLop
            // 
            txbDiemLop.Location = new Point(198, 52);
            txbDiemLop.Margin = new Padding(2, 3, 2, 3);
            txbDiemLop.Name = "txbDiemLop";
            txbDiemLop.Size = new Size(45, 30);
            txbDiemLop.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 56);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 23);
            label8.TabIndex = 32;
            label8.Text = "Điểm TB:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 56);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 31;
            label7.Text = "Điểm Thi:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 56);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 30;
            label6.Text = "Điểm Lớp:";
            label6.Click += label6_Click;
            // 
            // fBangDiem
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 534);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fBangDiem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bảng Điểm Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Label label9;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private TextBox txbLoai;
        private TextBox txbMaMonHoc;
        private TextBox txbMaSinhVien;
        private TextBox txbDiemTB;
        private TextBox txbDiemThi;
        private TextBox txbDiemLop;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}