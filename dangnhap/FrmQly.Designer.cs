namespace dangnhap
{
    partial class FrmQly
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnQuanlyhoadon = new System.Windows.Forms.Button();
            this.btnQuanlykhachhang = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnNCC);
            this.panel1.Controls.Add(this.btnNhaphang);
            this.panel1.Controls.Add(this.btnDangxuat);
            this.panel1.Controls.Add(this.btnQuanlyhoadon);
            this.panel1.Controls.Add(this.btnQuanlykhachhang);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 598);
            this.panel1.TabIndex = 0;
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.Location = new System.Drawing.Point(3, 181);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(347, 57);
            this.btnNhaphang.TabIndex = 4;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.UseVisualStyleBackColor = true;
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Location = new System.Drawing.Point(132, 557);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(96, 23);
            this.btnDangxuat.TabIndex = 3;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnQuanlyhoadon
            // 
            this.btnQuanlyhoadon.Location = new System.Drawing.Point(3, 371);
            this.btnQuanlyhoadon.Name = "btnQuanlyhoadon";
            this.btnQuanlyhoadon.Size = new System.Drawing.Size(347, 56);
            this.btnQuanlyhoadon.TabIndex = 2;
            this.btnQuanlyhoadon.Text = "Hóa đơn";
            this.btnQuanlyhoadon.UseVisualStyleBackColor = true;
            this.btnQuanlyhoadon.Click += new System.EventHandler(this.btnQuanlyhoadon_Click);
            // 
            // btnQuanlykhachhang
            // 
            this.btnQuanlykhachhang.Location = new System.Drawing.Point(4, 118);
            this.btnQuanlykhachhang.Name = "btnQuanlykhachhang";
            this.btnQuanlykhachhang.Size = new System.Drawing.Size(347, 57);
            this.btnQuanlykhachhang.TabIndex = 1;
            this.btnQuanlykhachhang.Text = "Khách hàng";
            this.btnQuanlykhachhang.UseVisualStyleBackColor = true;
            this.btnQuanlykhachhang.Click += new System.EventHandler(this.btnQuanlykhachhang_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(126, 35);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(77, 32);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Users";
            // 
            // button3
            // 
            this.button3.Image = global::dangnhap.Properties.Resources.quanlysieuthi;
            this.button3.Location = new System.Drawing.Point(376, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(613, 459);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnNCC
            // 
            this.btnNCC.Location = new System.Drawing.Point(3, 244);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(347, 57);
            this.btnNCC.TabIndex = 5;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // FrmQly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQly";
            this.Text = "Quản lý";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanlyhoadon;
        private System.Windows.Forms.Button btnQuanlykhachhang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDangxuat;
        protected System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.Button btnNCC;
    }
}