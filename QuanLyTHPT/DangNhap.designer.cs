namespace QuanLyTHPT
{
    partial class DangNhap
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
            this.thoat = new System.Windows.Forms.Button();
            this.BTN_DangNhap = new System.Windows.Forms.Button();
            this.showmk = new System.Windows.Forms.CheckBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.Color.Black;
            this.thoat.Location = new System.Drawing.Point(455, 287);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(165, 54);
            this.thoat.TabIndex = 12;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            // 
            // BTN_DangNhap
            // 
            this.BTN_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.BTN_DangNhap.Location = new System.Drawing.Point(188, 287);
            this.BTN_DangNhap.Name = "BTN_DangNhap";
            this.BTN_DangNhap.Size = new System.Drawing.Size(165, 54);
            this.BTN_DangNhap.TabIndex = 11;
            this.BTN_DangNhap.Text = "Đăng nhập";
            this.BTN_DangNhap.UseVisualStyleBackColor = false;
            this.BTN_DangNhap.Click += new System.EventHandler(this.BTN_DangNhap_Click);
            // 
            // showmk
            // 
            this.showmk.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showmk.Location = new System.Drawing.Point(310, 231);
            this.showmk.Name = "showmk";
            this.showmk.Size = new System.Drawing.Size(164, 24);
            this.showmk.TabIndex = 15;
            this.showmk.Text = "Hiển thị mật khẩu ";
            this.showmk.UseVisualStyleBackColor = true;
            // 
            // matkhau
            // 
            this.matkhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(310, 180);
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(344, 30);
            this.matkhau.TabIndex = 10;
            // 
            // taikhoan
            // 
            this.taikhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.Location = new System.Drawing.Point(310, 122);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(344, 30);
            this.taikhoan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tài khoản";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(119, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(602, 24);
            this.title.TabIndex = 9;
            this.title.Text = "HỆ THỐNG ĐĂNG NHẬP QUẢN LÝ HỌC SINH GIÁO VIÊN THPT";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 469);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.BTN_DangNhap);
            this.Controls.Add(this.showmk);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button BTN_DangNhap;
        private System.Windows.Forms.CheckBox showmk;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
    }
}