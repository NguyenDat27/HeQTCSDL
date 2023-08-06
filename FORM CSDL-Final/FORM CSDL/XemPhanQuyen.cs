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
    public partial class XemPhanQuyen : Form
    {
        public XemPhanQuyen()
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
        private void ktdn_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi động kết nối
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtTABLENAME
                string s = $"EXEC KiemTraDangNhap '{txtTK.Text}','{txtMK.Text}'";
                daTABLENAME = new SqlDataAdapter(s, conn);
                dtTABLENAME = new DataTable();
                daTABLENAME.Fill(dtTABLENAME);
                dataGridView1.DataSource = dtTABLENAME;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không tìm được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ktpq_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi động kết nối
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtTABLENAME
                string s = $"EXEC KiemTraQuyen '{txtPQ.Text}'";
                daTABLENAME = new SqlDataAdapter(s, conn);
                dtTABLENAME = new DataTable();
                daTABLENAME.Fill(dtTABLENAME);
                dataGridView1.DataSource = dtTABLENAME;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không tìm được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Quan_li ql = new Quan_li();
            ql.Show();
            this.Hide();
        }

        private void XemPhanQuyen_Load(object sender, EventArgs e)
        {

        }
    }
}
