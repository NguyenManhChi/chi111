using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dangnhap
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=NGUYE\\MANHCHI;Initial Catalog=netcuoiki;Integrated Security=True;Encrypt=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                                 "Xác nhận thoát",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            // Kiểm tra người dùng chọn Yes hay No
            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng
                Application.Exit();
            }
            else
            {
                // Người dùng chọn No, không làm gì cả
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = txtdangnhap.Text; // Input from "Tên Đăng Nhập"
            string password = txtdangky.Text; // Input from "Mật Khẩu"

            // Check if the user exists in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to check username and password
                    string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL Injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}