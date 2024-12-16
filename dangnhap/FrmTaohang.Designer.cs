using System.Drawing;
using System.Windows.Forms;

namespace dangnhap
{
    partial class FrmTaohang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.soLuongSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sanPhamTable = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tenSPTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maSPTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.soLuongSPHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.maSPHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ghiChuHoaDon = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tongTienHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hoaDonNhapHangTable = new System.Windows.Forms.DataGridView();
            this.maHoaDonNH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapHangTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.sanPhamTable);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(553, 636);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.soLuongSP);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.maSP);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(10, 526);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(537, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // soLuongSP
            // 
            this.soLuongSP.Location = new System.Drawing.Point(149, 69);
            this.soLuongSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soLuongSP.Name = "soLuongSP";
            this.soLuongSP.Size = new System.Drawing.Size(121, 22);
            this.soLuongSP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng nhập vào:";
            // 
            // maSP
            // 
            this.maSP.Location = new System.Drawing.Point(149, 30);
            this.maSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maSP.Name = "maSP";
            this.maSP.Size = new System.Drawing.Size(121, 22);
            this.maSP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sanPhamTable
            // 
            this.sanPhamTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanPhamTable.Location = new System.Drawing.Point(10, 163);
            this.sanPhamTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sanPhamTable.Name = "sanPhamTable";
            this.sanPhamTable.ReadOnly = true;
            this.sanPhamTable.RowHeadersWidth = 51;
            this.sanPhamTable.Size = new System.Drawing.Size(533, 358);
            this.sanPhamTable.TabIndex = 1;
            this.sanPhamTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanPhamTable_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.tenSPTK);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.maSPTK);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(530, 129);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(356, 88);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 31);
            this.button8.TabIndex = 11;
            this.button8.Text = "Tải lại";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 48);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tenSPTK
            // 
            this.tenSPTK.Location = new System.Drawing.Point(173, 93);
            this.tenSPTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenSPTK.Name = "tenSPTK";
            this.tenSPTK.Size = new System.Drawing.Size(121, 22);
            this.tenSPTK.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // maSPTK
            // 
            this.maSPTK.Location = new System.Drawing.Point(173, 53);
            this.maSPTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maSPTK.Name = "maSPTK";
            this.maSPTK.Size = new System.Drawing.Size(121, 22);
            this.maSPTK.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Lọc";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 21);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 20);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ghiChuHoaDon);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.hoaDonNhapHangTable);
            this.groupBox2.Controls.Add(this.maHoaDonNH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(572, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(567, 633);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn đặt hàng";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.soLuongSPHD);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Controls.Add(this.maSPHD);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(16, 430);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(544, 98);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // soLuongSPHD
            // 
            this.soLuongSPHD.Location = new System.Drawing.Point(148, 59);
            this.soLuongSPHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soLuongSPHD.Name = "soLuongSPHD";
            this.soLuongSPHD.Size = new System.Drawing.Size(121, 22);
            this.soLuongSPHD.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số lượng:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(387, 62);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 31);
            this.button6.TabIndex = 16;
            this.button6.Text = "Xóa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(387, 21);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 31);
            this.button7.TabIndex = 15;
            this.button7.Text = "Chỉnh sửa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // maSPHD
            // 
            this.maSPHD.Location = new System.Drawing.Point(148, 26);
            this.maSPHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maSPHD.Name = "maSPHD";
            this.maSPHD.Size = new System.Drawing.Size(121, 22);
            this.maSPHD.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ghi chú:";
            // 
            // ghiChuHoaDon
            // 
            this.ghiChuHoaDon.Location = new System.Drawing.Point(102, 70);
            this.ghiChuHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghiChuHoaDon.Multiline = true;
            this.ghiChuHoaDon.Name = "ghiChuHoaDon";
            this.ghiChuHoaDon.Size = new System.Drawing.Size(447, 62);
            this.ghiChuHoaDon.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.tongTienHoaDon);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(16, 533);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(544, 98);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(387, 62);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 31);
            this.button5.TabIndex = 16;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 21);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tongTienHoaDon
            // 
            this.tongTienHoaDon.Location = new System.Drawing.Point(148, 44);
            this.tongTienHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tongTienHoaDon.Name = "tongTienHoaDon";
            this.tongTienHoaDon.Size = new System.Drawing.Size(121, 22);
            this.tongTienHoaDon.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền:";
            // 
            // hoaDonNhapHangTable
            // 
            this.hoaDonNhapHangTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonNhapHangTable.Location = new System.Drawing.Point(16, 160);
            this.hoaDonNhapHangTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoaDonNhapHangTable.Name = "hoaDonNhapHangTable";
            this.hoaDonNhapHangTable.ReadOnly = true;
            this.hoaDonNhapHangTable.RowHeadersWidth = 51;
            this.hoaDonNhapHangTable.Size = new System.Drawing.Size(544, 256);
            this.hoaDonNhapHangTable.TabIndex = 10;
            this.hoaDonNhapHangTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoaDonNhapHangTable_CellContentClick);
            // 
            // maHoaDonNH
            // 
            this.maHoaDonNH.Location = new System.Drawing.Point(289, 31);
            this.maHoaDonNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maHoaDonNH.Name = "maHoaDonNH";
            this.maHoaDonNH.Size = new System.Drawing.Size(121, 22);
            this.maHoaDonNH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // FrmTaohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTaohang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoHoaDonNhapHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapHangTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private DataGridView sanPhamTable;
        private GroupBox groupBox3;
        private Button button1;
        private Label label1;
        private TextBox soLuongSP;
        private Label label2;
        private TextBox maSP;
        private Button button3;
        private TextBox tenSPTK;
        private Label label4;
        private TextBox maSPTK;
        private Label label3;
        private Button button2;
        private ListBox listBox1;
        private TextBox maHoaDonNH;
        private Label label5;
        private GroupBox groupBox5;
        private Button button4;
        private TextBox tongTienHoaDon;
        private Label label6;
        private DataGridView hoaDonNhapHangTable;
        private TextBox ghiChuHoaDon;
        private Label label7;
        private Button button5;
        private GroupBox groupBox6;
        private Button button6;
        private Button button7;
        private TextBox maSPHD;
        private Label label8;
        private TextBox soLuongSPHD;
        private Label label9;
        private Button button8;
    }
}