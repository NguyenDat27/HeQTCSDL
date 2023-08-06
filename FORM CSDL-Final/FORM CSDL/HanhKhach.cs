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
    public partial class Hanh_khach : Form
    {
        public Hanh_khach()
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
        private void label3_Click(object sender, EventArgs e)
        {

        }
        void hien_thi()
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            this.text_CMND.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_Hoten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.date_sinh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.text_dia_chi.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.text_sdt.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();  
        }
        void Reset()
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            this.text_CMND.ResetText();
            this.text_Hoten.ResetText();
            this.date_sinh.ResetText();
            this.text_dia_chi.ResetText();
            this.text_sdt.ResetText();
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
                MessageBox.Show("Không lấy được nội dung trong table HANHKHACH.Lỗi rồi!!!");
            }
        }
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

        private void Hanh_khach_Load(object sender, EventArgs e)
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from HANHKHACH", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
            dataGridView1.DataSource = dtTABLENAME;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            hien_thi();
        }

        private void textB_Hoten_TextChanged(object sender, EventArgs e)
        {

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
                System.String.Concat("EXEC Insert_HanhKhach'" + text_CMND.Text + "','"
                + text_Hoten.Text + "','" + date_sinh.Text + "','" + text_dia_chi.Text + "','" + text_sdt.Text+"'"
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
                System.String.Concat("EXEC Update_HanhKhach'" + text_CMND.Text + "','"
                + text_Hoten.Text + "','" + date_sinh.Text + "','" + text_dia_chi.Text + "','" + text_sdt.Text + "'"

                );

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

        private void button_delete_Click(object sender, EventArgs e)
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
                cmd.CommandText =
                    System.String.Concat("EXEC Delete_HanhKhach '"+text_CMND.Text+"'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                Reset();
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
    }
}
