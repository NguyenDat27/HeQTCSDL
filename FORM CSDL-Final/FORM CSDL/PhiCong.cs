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
namespace FORM_CSDL
{
    public partial class PhiCong : Form
    {
        public PhiCong()
        {
            InitializeComponent();
        }
        string strConnectionString = @"Data Source=(local);Initial Catalog=QUAN_LI_CHUYEN_BAY;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTABLENAME
        SqlDataAdapter daTABLENAME = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtTABLENAME = null;

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                Quan_li ql = new Quan_li();
                ql.Show();
                this.Hide();
            }

        }
        void LoadData()
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu vào DataTable dtThanhPho

                dtTABLENAME = new DataTable();
                dtTABLENAME.Clear();
                daTABLENAME.Fill(dtTABLENAME);
                // Đưa dữ liệu lên DataGridViewLưu hành nội bộ Trang 78
                dataGridView1.DataSource = dtTABLENAME;
                hien_thi();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung Lỗi rồi!!!");
            }

        }

        private void PhiCong_Load(object sender, EventArgs e)
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from PhiCong", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
            dataGridView1.DataSource = dtTABLENAME;

        }
        void hien_thi()
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Lấy MaKH của record hiện hành
            //string strSohieu = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_MaPC.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_TenPC.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.text_DiaChi.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.text_SDT.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.text_Luong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            this.text_giobay.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            hien_thi();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            try
            {


                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Viết câu lệnh SQL

                string s = $"EXEC proc_insert_PC '{this.text_MaPC.Text}','{this.text_TenPC.Text}'," +
               $"'{this.text_DiaChi.Text}','{this.text_SDT.Text}'";
                cmd.CommandText =
                System.String.Concat(s);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã them xong!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không them được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
            // Đóng kết nối
            conn.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            try
            {


                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Viết câu lệnh SQL
                string s = $"EXEC proc_update_PC '{this.text_MaPC.Text}','{this.text_TenPC.Text}'," +
                    $"'{this.text_DiaChi.Text}','{this.text_SDT.Text}'   ";
                cmd.CommandText =
                System.String.Concat(s);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sữa xong!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không sua được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
            // Đóng kết nối
            conn.Close();

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                hien_thi();
                // Viết câu lệnh SQL
                string s = $"proc_delete_PC '{this.text_MaPC.Text}'";
                cmd.CommandText = System.String.Concat(s);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
            // Đóng kết nối
            conn.Close();
        }

        private void text_Luong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
