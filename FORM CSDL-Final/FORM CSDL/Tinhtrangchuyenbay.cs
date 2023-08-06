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
    public partial class Tinhtrangchuyenbay : Form
    {
        public Tinhtrangchuyenbay()
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

        private void Tinhtrangchuyenbay_Load(object sender, EventArgs e)
        {
           
            

        }
        void LoadData()
        {
            conn.Open();
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
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong .Lỗi rồi!!!");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtTABLENAME
                string s = $"EXEC proc_Thong_ke_tinh_trang_chuyen_bay_catcanh_tu_ngay_xy '{date_begin.Text}' ,'{dateTime_end.Text}'";
                daTABLENAME = new SqlDataAdapter(s, conn);
                dtTABLENAME = new DataTable();
                daTABLENAME.Fill(dtTABLENAME);
                dataGridView1.DataSource = dtTABLENAME;
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }

        }

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
    }





    //string s = $"EXEC proc_Thong_ke_tinh_trang_chuyen_bay_catcanh_tu_ngay_xy '{date_begin.Text}' ,'{dateTime_end.Text}'";
}

