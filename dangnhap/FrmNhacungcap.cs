using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dangnhap
{
    public partial class FrmNhacungcap : Form
    {
        private string maHoaDonNK;
        private int currentUserId;
        private SqlConnection connection;
        private string str = "Data Source=NGUYE\\MANHCHI;Initial Catalog=netcuoiki;Integrated Security=True";
        public FrmNhacungcap(int currentUserId, string ma)
        {
            InitializeComponent();
            this.currentUserId = currentUserId;
            this.maHoaDonNK = ma;
            loadUser();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {

            string query = "SELECT maNhaCungCap, hoTen, diachi, soDienThoai, gmail FROM NhaCungCap";

            try
            {
                // Sử dụng `using` để tự động quản lý kết nối
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    // Sử dụng SqlDataAdapter để tải dữ liệu vào DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán trực tiếp DataTable làm nguồn dữ liệu cho DataGridView
                        dataGridView1.DataSource = dataTable;

                        // Thiết lập tiêu đề cột (nếu chưa thiết lập)
                        if (dataGridView1.Columns["maNhaCungCap"] != null)
                        {
                            dataGridView1.Columns["maNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
                        }
                        if (dataGridView1.Columns["hoTen"] != null)
                        {
                            dataGridView1.Columns["hoTen"].HeaderText = "Họ Tên";
                        }
                        if (dataGridView1.Columns["diachi"] != null)
                        {
                            dataGridView1.Columns["diachi"].HeaderText = "Địa Chỉ";
                        }
                        if (dataGridView1.Columns["soDienThoai"] != null)
                        {
                            dataGridView1.Columns["soDienThoai"].HeaderText = "Số Điện Thoại";
                        }
                        if (dataGridView1.Columns["gmail"] != null)
                        {
                            dataGridView1.Columns["gmail"].HeaderText = "Gmail";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetName(int userId)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Unknown User";
        }
        private void loadUser()
        {

            lbUser.Text = GetName(currentUserId);
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

        private void btnQuanlykhachhang_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmKhachhang frmKhachhang = new FrmKhachhang(currentUserId, maHoaDonNK);
            frmKhachhang.Show();
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmNhaphang frmK = new FrmNhaphang(maHoaDonNK);
            frmK.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanlyhoadon_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHoadon hoadon = new frmHoadon(currentUserId, maHoaDonNK);
            hoadon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string input = txtMaNCC.Text.Trim();

            // Kiểm tra xem input có phải là số nguyên hợp lệ không
            if (int.TryParse(input, out int id))
            {
                // Chắc chắn giá trị nhập vào là số hợp lệ
                string ten = txtTen.Text.Trim();
                string diachi = txtDiachi.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string gmail = txtEmail.Text.Trim();

                // Thực hiện truy vấn thêm vào cơ sở dữ liệu
                string queryInsert = "INSERT INTO NhaCungCap (maNhaCungCap, hoTen, diachi, soDienThoai, gmail) " +
                                     "VALUES (@maNhaCungCap, @hoTen, @diachi, @soDienThoai, @gmail)";

                try
                {
                    // Sử dụng using để đảm bảo kết nối được đóng đúng cách
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        SqlCommand cmdInsert = new SqlCommand(queryInsert, connection);
                        cmdInsert.Parameters.AddWithValue("@maNhaCungCap", id); // Dùng id đã được chuyển đổi sang int
                        cmdInsert.Parameters.AddWithValue("@hoTen", ten);
                        cmdInsert.Parameters.AddWithValue("@diachi", diachi);
                        cmdInsert.Parameters.AddWithValue("@soDienThoai", sdt);
                        cmdInsert.Parameters.AddWithValue("@gmail", gmail);

                        connection.Open(); // Mở kết nối trước khi thực thi câu lệnh
                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhà cung cấp thành công!");
                        LoadDataGridView();  // Làm mới DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message);
                }
            }
            else
            {
                // Thông báo lỗi nếu người dùng nhập không phải là số nguyên
                MessageBox.Show("Mã nhà cung cấp không hợp lệ. Vui lòng nhập số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiachi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtSDT.Text, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(txtMaNCC.Text, out id))
            {
                MessageBox.Show("Mã nhà cung cấp phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ten = txtTen.Text.Trim();
            string diachi = txtDiachi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string gmail = txtEmail.Text.Trim();

            string queryUpdate = @"UPDATE NhaCungCap 
                           SET hoTen = @hoTen, diachi = @diachi, soDienThoai = @soDienThoai, gmail = @gmail 
                           WHERE maNhaCungCap = @maNhaCungCap";

            // Sử dụng `using` để tự động quản lý tài nguyên
            using (SqlConnection conn = new SqlConnection(str))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@maNhaCungCap", id);
                        cmdUpdate.Parameters.AddWithValue("@hoTen", ten);
                        cmdUpdate.Parameters.AddWithValue("@diachi", diachi);
                        cmdUpdate.Parameters.AddWithValue("@soDienThoai", sdt);
                        cmdUpdate.Parameters.AddWithValue("@gmail", gmail);

                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView(); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp với mã cung cấp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi cơ sở dữ liệu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(txtMaNCC.Text, out id))
            {
                MessageBox.Show("Mã nhà cung cấp phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                return; // Thoát nếu người dùng chọn "No"
            }

            string queryDelete = @"DELETE FROM NhaCungCap WHERE maNhaCungCap = @maNhaCungCap";

            // Sử dụng `using` để tự động quản lý tài nguyên
            using (SqlConnection conn = new SqlConnection(str))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmdDelete = new SqlCommand(queryDelete, conn))
                    {
                        cmdDelete.Parameters.AddWithValue("@maNhaCungCap", id);

                        int rowsAffected = cmdDelete.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView(); // Tải lại dữ liệu
                            txtMaNCC.Clear();
                            txtEmail.Clear();
                            txtDiachi.Clear();
                            txtSDT.Clear();
                            txtTen.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp với mã cung cấp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi cơ sở dữ liệu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(txtMaNCC.Text, out id))
            {
                MessageBox.Show("Mã nhà cung cấp phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string querySearch = "SELECT * FROM NhaCungCap WHERE maNhaCungCap = @maNhaCungCap";

            // Sử dụng `using` để tự động quản lý tài nguyên
            using (SqlConnection conn = new SqlConnection(str))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmdSearch = new SqlCommand(querySearch, conn))
                    {
                        cmdSearch.Parameters.AddWithValue("@maNhaCungCap", id);

                        using (SqlDataReader reader = cmdSearch.ExecuteReader())
                        {
                            // Xóa dữ liệu cũ trong DataGridView
                            dataGridView1.Rows.Clear();

                            // Nếu tìm thấy kết quả
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Thêm dòng dữ liệu vào DataGridView
                                    dataGridView1.Rows.Add(
                                        reader["maNhaCungCap"].ToString(),
                                        reader["hoTen"].ToString(),
                                        reader["diachi"].ToString(),
                                        reader["soDienThoai"].ToString(),
                                        reader["gmail"].ToString()
                                    );
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi cơ sở dữ liệu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Kiểm tra nếu người dùng click vào một hàng hợp lệ (không phải tiêu đề)

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ DataGridView vào các TextBox
                txtMaNCC.Text = row.Cells["maNhaCungCap"].Value.ToString();
                txtTen.Text = row.Cells["hoTen"].Value.ToString();
                txtDiachi.Text = row.Cells["diachi"].Value.ToString();
                txtSDT.Text = row.Cells["soDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["gmail"].Value.ToString();
            }
        }
    }
}
