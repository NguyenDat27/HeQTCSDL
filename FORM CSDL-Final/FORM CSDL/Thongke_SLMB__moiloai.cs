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
    public partial class Thongke_SLMB__moiloai : Form
    {
        public Thongke_SLMB__moiloai()
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

        private void Thongke_SLMB__moiloai_Load(object sender, EventArgs e)
        {
            try
            {
                
                // Khởi động kết nối
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtTABLENAME
                daTABLENAME = new SqlDataAdapter("Select * from  SoLuongMayBay_View", conn);
                dtTABLENAME = new DataTable();
                daTABLENAME.Fill(dtTABLENAME);
                dataGridView1.DataSource = dtTABLENAME;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong.Lỗi rồi!!!");
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
}
