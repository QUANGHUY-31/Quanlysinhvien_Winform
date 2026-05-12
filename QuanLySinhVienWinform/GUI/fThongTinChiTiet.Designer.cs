namespace QuanLySinhVienWinForm.GUI
{
    partial class fThongTinChiTiet
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
            label1 = new Label();
            txbTenDangNhap = new TextBox();
            txbMatKhau = new TextBox();
            label2 = new Label();
            txbLoaiTaiKhoan = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(18, 47);
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(236, 26);
            txbTenDangNhap.TabIndex = 1;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(18, 117);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(236, 26);
            txbMatKhau.TabIndex = 3;
            txbMatKhau.Text = "***********";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu:";
            // 
            // txbLoaiTaiKhoan
            // 
            txbLoaiTaiKhoan.Location = new Point(18, 194);
            txbLoaiTaiKhoan.Name = "txbLoaiTaiKhoan";
            txbLoaiTaiKhoan.Size = new Size(236, 26);
            txbLoaiTaiKhoan.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 160);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 4;
            label3.Text = "Loại Tài Khoản:";
            // 
            // fThongTinChiTiet
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 235);
            Controls.Add(txbLoaiTaiKhoan);
            Controls.Add(label3);
            Controls.Add(txbMatKhau);
            Controls.Add(label2);
            Controls.Add(txbTenDangNhap);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fThongTinChiTiet";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông Tin Chi Tiết";
            Load += fThongTinChiTiet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbTenDangNhap;
        private TextBox txbMatKhau;
        private Label label2;
        private TextBox txbLoaiTaiKhoan;
        private Label label3;
    }
}