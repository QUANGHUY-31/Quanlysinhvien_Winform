namespace BaiTapLon
{
    partial class fDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbTenDangNhap = new TextBox();
            label2 = new Label();
            txbMatKhau = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập";
            label1.Click += label1_Click;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.AllowDrop = true;
            txbTenDangNhap.Location = new Point(12, 55);
            txbTenDangNhap.Margin = new Padding(2, 3, 2, 3);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(287, 30);
            txbTenDangNhap.TabIndex = 0;
            txbTenDangNhap.TextChanged += txbTenDangNhap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(12, 132);
            txbMatKhau.Margin = new Padding(2, 3, 2, 3);
            txbMatKhau.MaxLength = 255;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(285, 30);
            txbMatKhau.TabIndex = 1;
            txbMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(87, 201);
            btnDangNhap.Margin = new Padding(2, 3, 2, 3);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(125, 40);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.TabStop = false;
            btnDangNhap.Text = " Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += fDangNhap_Click;
            // 
            // fDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(235, 245, 251);
            ClientSize = new Size(312, 283);
            Controls.Add(btnDangNhap);
            Controls.Add(txbMatKhau);
            Controls.Add(label2);
            Controls.Add(txbTenDangNhap);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += fDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbTenDangNhap;
        private Label label2;
        private TextBox txbMatKhau;
        private Button btnDangNhap;
    }
}
