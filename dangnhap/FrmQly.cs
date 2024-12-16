using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dangnhap
{
    public partial class FrmQly : Form
    {
        private string connectionString = "Data Source=NGUYE\\MANHCHI;Initial Catalog=netcuoiki;Integrated Security=True";
        private SqlConnection conn;
        private int currentUserId;
        private string maHoaDonNK;
        public FrmQly(int id, string maHoaDonNK)
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            this.currentUserId = id;
            loadUser();
            this.maHoaDonNK = maHoaDonNK;
        }
        private string GetName(int userId)
        {

            try
            {
                conn.Open();
                string query = "SELECT Username FROM Users WHERE UserID = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
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
                conn.Close();

            }
            return "Unknown User"; 
        }
        private void loadUser()
        {

            lbUser.Text = GetName(currentUserId);
        }

        private void btnQuanlykhachhang_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmKhachhang frm = new FrmKhachhang(currentUserId, maHoaDonNK);
            frm.Show();
        }

        private void btnQuanlyhoadon_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHoadon frm = new frmHoadon(currentUserId, maHoaDonNK);
            frm.Show();
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
