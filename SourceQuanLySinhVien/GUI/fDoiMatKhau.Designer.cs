namespace BaiTapLon.GUI
{
    partial class fDoiMatKhau
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
            txbMatKhauMoi = new TextBox();
            label2 = new Label();
            txbMatKhauCu = new TextBox();
            label1 = new Label();
            btnCapNhat = new Button();
            SuspendLayout();
            // 
            // txbMatKhauMoi
            // 
            txbMatKhauMoi.Location = new Point(12, 115);
            txbMatKhauMoi.MaxLength = 255;
            txbMatKhauMoi.Name = "txbMatKhauMoi";
            txbMatKhauMoi.Size = new Size(236, 26);
            txbMatKhauMoi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 8;
            label2.Text = "Mật Khẩu Mới:";
            // 
            // txbMatKhauCu
            // 
            txbMatKhauCu.Location = new Point(12, 45);
            txbMatKhauCu.MaxLength = 255;
            txbMatKhauCu.Name = "txbMatKhauCu";
            txbMatKhauCu.Size = new Size(236, 26);
            txbMatKhauCu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 6;
            label1.Text = "Mật Khẩu Cũ:";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(80, 166);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(90, 27);
            btnCapNhat.TabIndex = 10;
            btnCapNhat.TabStop = false;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // fDoiMatKhau
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 225);
            Controls.Add(btnCapNhat);
            Controls.Add(txbMatKhauMoi);
            Controls.Add(label2);
            Controls.Add(txbMatKhauCu);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fDoiMatKhau";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            Load += fDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbMatKhauMoi;
        private Label label2;
        private TextBox txbMatKhauCu;
        private Label label1;
        private Button btnCapNhat;
    }
}