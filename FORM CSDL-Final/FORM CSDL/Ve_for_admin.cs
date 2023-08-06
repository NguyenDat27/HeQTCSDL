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
    public partial class Ve_for_admin : Form
    {
        public Ve_for_admin()
        {
            InitializeComponent();
        }
        // Chuỗi kết nối
        string strConnectionString = @"Data Source=(local);Initial Catalog=QUAN_LI_CHUYEN_BAY;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTABLENAME
        SqlDataAdapter daTABLENAME = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtTABLENAME = null;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Ve_for_admin_Load(object sender, EventArgs e)
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from VE", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
            dataGridView1.DataSource = dtTABLENAME;

        }

        private void button4_Click(object sender, EventArgs e)
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
                string s = $"EXEC proc_insert_Ve '{this.text_CMND.Text}'," +
                    $"'{this.text_MaCB.Text}','{this.date_catcanh.Text}','{this.date_hacanh.Text}','{this.date_canbay.Text}'," +
                    $"'{this.com_candi.Text}','{this.combo_canden.Text}'," +
                    $"{int.Parse(this.text_Soghe.Text)},{float.Parse(this.text_GiaVe.Text)}";
                     
                
                cmd.CommandText =
                System.String.Concat(s

                );

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
                //hien_thi();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong.Lỗi rồi!!!");
            }
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
                string s = $"EXEC  proc_update_Ve {int.Parse(this.text_ID.Text)} ,'{this.text_CMND.Text}'," +
                    $"'{this.text_MaCB.Text}','{this.date_catcanh.Text}','{this.date_hacanh.Text}','{this.date_canbay.Text}'," +
                    $"'{this.com_candi.Text}','{this.combo_canden.Text}'," +
                    $"{int.Parse(this.text_Soghe.Text)},{float.Parse(this.text_GiaVe.Text)}";
                    
                cmd.CommandText =
                System.String.Concat(s);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sua xong!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không sua được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
            // Đóng kết nối
            conn.Close();


        }
        void hien_thi()
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.text_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_CMND.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.text_MaCB.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.date_catcanh.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            this.date_hacanh.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            this.date_canbay.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            this.com_candi.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            this.combo_canden.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            this.text_Trang_thai.Text = dataGridView1.Rows[r].Cells[9].Value.ToString();
            this.text_Soghe.Text = dataGridView1.Rows[r].Cells[10].Value.ToString();
            this.text_GiaVe.Text = dataGridView1.Rows[r].Cells[11].Value.ToString();
            this.text_Phiphatsinh.Text= dataGridView1.Rows[r].Cells[12].Value.ToString();
            this.text_khuyenmai.Text = dataGridView1.Rows[r].Cells[13].Value.ToString();


        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
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
                string s = $"EXEC proc_delete_Ve {int.Parse(this.text_ID.Text)}";
                
                cmd.CommandText =
                    System.String.Concat(s);
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            hien_thi();
        }
    }
}
