using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangnhap
{
    
    public partial class FrmNhaphang : Form
    {

        private int currentid;
        private string str = "Data Source=NGUYE\\MANHCHI;Initial Catalog=netcuoiki;Integrated Security=True";
        private SqlConnection conn;
        private string maHoaDonNK;
        public FrmNhaphang(string maHoaDonNK)
        {
            InitializeComponent();
            conn = new SqlConnection(str);
            this.maHoaDonNK = maHoaDonNK;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmQly ql = new FrmQly(currentid, maHoaDonNK);
            ql.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maHDNM = maHDKT.Text;

            try
            {
                conn.Open();
                string selectHD = "SELECT maHoaDon, ghiChu, ngayNhap, SUM(thanhTien) AS thanhTien " +
                                    "FROM NhapKho " +
                                    "WHERE maHoaDon = @maHoaDon " +
                                    "GROUP BY maHoaDon, ghiChu, ngayNhap order by maHoaDon ASC";
                using (SqlCommand cmd = new SqlCommand(selectHD, conn))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHDNM);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    hoaDonNhapKho.DataSource = dt;

                    hoaDonNhapKho.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                    hoaDonNhapKho.Columns["ghiChu"].HeaderText = "Ghi Chú";
                    hoaDonNhapKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
                    hoaDonNhapKho.Columns["thanhTien"].HeaderText = "Thành Tiền";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ngayMBatDau = dateFrom.Value.ToString("yyyy-MM-dd");
            String ngayMKetThuc = dateEnd.Value.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                string selectHD = "SELECT maHoaDon, ghiChu, ngayNhap, SUM(thanhTien) AS thanhTien " +
                                  "FROM NhapKho " +
                                  "WHERE ngayNhap BETWEEN @ngayMBatDau AND @ngayMKetThuc " +
                                  "GROUP BY maHoaDon, ghiChu, ngayNhap ORDER BY maHoaDon ASC";
                using (SqlCommand cmd = new SqlCommand(selectHD, conn))
                {
                    cmd.Parameters.AddWithValue("@ngayMBatDau", ngayMBatDau);
                    cmd.Parameters.AddWithValue("@ngayMKetThuc", ngayMKetThuc);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    hoaDonNhapKho.DataSource = dt;

                    // Thiết lập tiêu đề cho các cột
                    hoaDonNhapKho.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                    hoaDonNhapKho.Columns["ghiChu"].HeaderText = "Ghi Chú";
                    hoaDonNhapKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
                    hoaDonNhapKho.Columns["thanhTien"].HeaderText = "Thành Tiền";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTaohang frm = new FrmTaohang(maHoaDonNK);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDon.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn hóa đơn !");
                return;
            }
            this.Hide();
            FrmChinhsuanhaphang frmChinhsua = new FrmChinhsuanhaphang(maHoaDonNK);
            frmChinhsua.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDon.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn hóa đơn !");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    string deleteHD = "DELETE FROM NhapKho WHERE maHoaDon = @maHoaDon";
                    using (SqlCommand cmd = new SqlCommand(deleteHD, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hóa đơn đã được xóa thành công !");

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn cần xóa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình xóa: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                FrmNhaphang_Load(sender, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmNhaphang_Load(sender, e);
        }

        private void FrmNhaphang_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string selectHD = "SELECT maHoaDon, ghiChu, ngayNhap, SUM(thanhTien) AS thanhTien " +
                                    "FROM NhapKho " +
                                    "GROUP BY maHoaDon, ghiChu, ngayNhap";
                using (SqlCommand cmd = new SqlCommand(selectHD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    hoaDonNhapKho.DataSource = dt;

                    hoaDonNhapKho.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                    hoaDonNhapKho.Columns["ghiChu"].HeaderText = "Ghi Chú";
                    hoaDonNhapKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
                    hoaDonNhapKho.Columns["thanhTien"].HeaderText = "Thành Tiền";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void hoaDonNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && hoaDonNhapKho.Rows[e.RowIndex].Cells["maHoaDon"].Value != null)
            {
                hoaDonNhapKho.Rows[e.RowIndex].Selected = true;
                maHoaDon.Text = hoaDonNhapKho["maHoaDon", e.RowIndex].Value.ToString();
            }
        }
    }
}
