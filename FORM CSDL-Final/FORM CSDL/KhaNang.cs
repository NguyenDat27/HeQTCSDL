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
    public partial class KhaNang : Form
    {
        public KhaNang()
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

        private void KhaNang_Load(object sender, EventArgs e)
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from KhaNang", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
            dataGridView1.DataSource = dtTABLENAME;

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
        void hien_thi()
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Lấy MaKH của record hiện hành
            //string strSohieu = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_MaPC.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_MaLoaiMayBay.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
                string s = $"EXEC proc_delete_KhaNang '{this.text_MaPC.Text}','{this.text_MaLoaiMayBay.Text}'";
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

        private void button1_Click(object sender, EventArgs e)
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
                string s = $"EXEC proc_insert_KhaNang '{this.text_MaPC.Text}','{this.text_MaLoaiMayBay.Text}'";
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            hien_thi();
        }
    }
}
