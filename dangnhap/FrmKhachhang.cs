using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dangnhap
{
    public partial class FrmKhachhang : Form
    {
        private int currentUserId;
        private SqlConnection connection;
        private SqlCommand command;
        private string str = "Data Source=NGUYE\\MANHCHI;Initial Catalog=netcuoiki;Integrated Security=True";
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        private string maHoaDonNK;
        public FrmKhachhang(int id, string maHoaDonNK)
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            this.currentUserId = id;
            loadUser();
            this.maHoaDonNK = maHoaDonNK;
        }
        private string GetName(int userId)
        {

            try
            {
                connection.Open();
                string query = "SELECT Username FROM Users WHERE UserID = @userId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();

            }
            return "Unknown User";
        }
        private void loadUser()
        {

            lbUser.Text = GetName(currentUserId);
        }
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhachhang.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmakhachhang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbogioitinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtsodienthoai.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KhachHang values(N'" + txtmakhachhang.Text + "',N'" + txthoten.Text + "',N'" + cbogioitinh.Text + "',N'" + txtsodienthoai.Text + "',N'" + txtdiachi.Text + "',N')";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtmakhachhang.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // 1. Xóa dữ liệu liên quan từ XuatKho
                    string deleteXuatKho = "DELETE FROM XuatKho WHERE maKhachHang = @maKhachHang";
                    using (SqlCommand cmdXuatKho = new SqlCommand(deleteXuatKho, connection))
                    {
                        cmdXuatKho.Parameters.AddWithValue("@maKhachHang", txtmakhachhang.Text);
                        cmdXuatKho.ExecuteNonQuery();
                    }

                    // 2. Xóa dữ liệu liên quan từ HoaDonBanHang
                    string deleteHoaDon = "DELETE FROM HoaDonBanHang WHERE maKhachHang = @maKhachHang";
                    using (SqlCommand cmdHoaDon = new SqlCommand(deleteHoaDon, connection))
                    {
                        cmdHoaDon.Parameters.AddWithValue("@maKhachHang", txtmakhachhang.Text);
                        cmdHoaDon.ExecuteNonQuery();
                    }

                    string query = "DELETE FROM KhachHang WHERE maKhachHang = @maKhachHang";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số an toàn
                        command.Parameters.AddWithValue("@maKhachHang", txtmakhachhang.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            loaddata();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi ràng buộc khóa ngoại
                    if (ex.Number == 547) // Lỗi ràng buộc khóa ngoại
                    {
                        MessageBox.Show("Không thể xóa khách hàng này vì có dữ liệu liên quan trong hệ thống.",
                                        "Lỗi ràng buộc",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin khách hàng này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update KhachHang set hoTen = N'" + txthoten.Text +
                                          "', gioiTinh = N'" + cbogioitinh.Text +
                                          "', soDienThoai = N'" + txtsodienthoai.Text +
                                          "', diaChi = N'" + txtdiachi.Text +
                                          "' where maKhachHang = N'" + txtmakhachhang.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnkhoitao_Click(object sender, EventArgs e)
        {
            txtmakhachhang.Text = "";
            txthoten.Text = "";
            cbogioitinh.Text = "";
            txtsodienthoai.Text = "";
            txtdiachi.Text = "";
        }
        private void FrmKhachhang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void btnQuanlyhoadon_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHoadon hoadon = new frmHoadon(currentUserId, maHoaDonNK);
            hoadon.Show();
        }

        private void btnQuanlykhachhang_Click(object sender, EventArgs e)
        {

        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // Nếu có, đóng form hiện tại và quay lại form đăng nhập
                this.Close(); // Ẩn form hiện tại
                frmLogin formDangNhap = new frmLogin(maHoaDonNK); // Tạo form đăng nhập mới
                formDangNhap.Show(); // Hiển thị form đăng nhập
            }
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmNhaphang frm = new FrmNhaphang(maHoaDonNK);
            frm.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmNhacungcap frmNhacungcap = new FrmNhacungcap(currentUserId, maHoaDonNK);
            frmNhacungcap.Show();
        }
    }
}
