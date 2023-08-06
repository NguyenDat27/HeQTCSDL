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
    public partial class Maybay : Form
    {
        public Maybay()
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
        
        private void button_EXIT_Click(object sender, EventArgs e)
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
                MessageBox.Show("Không lấy được nội dung trong table May bay.Lỗi rồi!!!");
            }
        }
        private void Maybay_Load(object sender, EventArgs e)
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from Maybay", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
            dataGridView1.DataSource=dtTABLENAME;
        }

        private void button_delete_Click(object sender, EventArgs e)
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
                cmd.CommandText = System.String.Concat("Delete From MAYBAY Where SoHieu = '" +this.text_sohieu + "'");
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
        void hien_thi()
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Lấy MaKH của record hiện hành
            //string strSohieu = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_sohieu.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_maloaimaybay.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.text_ghetrong.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
        }

        private void Maybay_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                cmd.CommandText =
                System.String.Concat("EXEC INSERT_MAY_BAY'"+this.text_sohieu.Text+"','"+this.text_maloaimaybay.Text+"',"+int .Parse(this.text_ghetrong.Text));
                
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
                
                cmd.CommandText =
                System.String.Concat("EXEC UPDATE_MAY_BAY'" + this.text_sohieu.Text + "','" + this.text_maloaimaybay.Text + "'," + 75);

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

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            hien_thi();
        }
    }
}
