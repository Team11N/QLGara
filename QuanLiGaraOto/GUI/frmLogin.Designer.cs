namespace QuanLiGaraOto
{
    partial class frmLogin
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
            this.labTaikhoan = new System.Windows.Forms.Label();
            this.labMatkhau = new System.Windows.Forms.Label();
            this.tbTaikhoan = new System.Windows.Forms.TextBox();
            this.tbMatkhau = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTaikhoan
            // 
            this.labTaikhoan.AutoSize = true;
            this.labTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTaikhoan.Location = new System.Drawing.Point(139, 15);
            this.labTaikhoan.Name = "labTaikhoan";
            this.labTaikhoan.Size = new System.Drawing.Size(72, 15);
            this.labTaikhoan.TabIndex = 0;
            this.labTaikhoan.Text = "Tài Khoản";
            // 
            // labMatkhau
            // 
            this.labMatkhau.AutoSize = true;
            this.labMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatkhau.Location = new System.Drawing.Point(139, 50);
            this.labMatkhau.Name = "labMatkhau";
            this.labMatkhau.Size = new System.Drawing.Size(68, 15);
            this.labMatkhau.TabIndex = 1;
            this.labMatkhau.Text = "Mật Khẩu";
            // 
            // tbTaikhoan
            // 
            this.tbTaikhoan.Location = new System.Drawing.Point(227, 14);
            this.tbTaikhoan.Name = "tbTaikhoan";
            this.tbTaikhoan.Size = new System.Drawing.Size(160, 20);
            this.tbTaikhoan.TabIndex = 2;
            this.tbTaikhoan.TextChanged += new System.EventHandler(this.tbTaikhoan_TextChanged);
            this.tbTaikhoan.Enter += new System.EventHandler(this.tbTaikhoan_Enter);
            this.tbTaikhoan.Leave += new System.EventHandler(this.tbTaikhoan_Leave);
            // 
            // tbMatkhau
            // 
            this.tbMatkhau.Location = new System.Drawing.Point(227, 49);
            this.tbMatkhau.Name = "tbMatkhau";
            this.tbMatkhau.Size = new System.Drawing.Size(160, 20);
            this.tbMatkhau.TabIndex = 3;
            this.tbMatkhau.UseSystemPasswordChar = true;
            this.tbMatkhau.TextChanged += new System.EventHandler(this.tbMatkhau_TextChanged);
            this.tbMatkhau.Enter += new System.EventHandler(this.tbMatkhau_Enter);
            this.tbMatkhau.Leave += new System.EventHandler(this.tbMatkhau_Leave);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(185, 100);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(301, 100);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::QuanLiGaraOto.Properties.Resources.images;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 107);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 150);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.tbMatkhau);
            this.Controls.Add(this.tbTaikhoan);
            this.Controls.Add(this.labMatkhau);
            this.Controls.Add(this.labTaikhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTaikhoan;
        private System.Windows.Forms.Label labMatkhau;
        private System.Windows.Forms.TextBox tbTaikhoan;
        private System.Windows.Forms.TextBox tbMatkhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

