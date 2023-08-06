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
    public partial class HuyVeforHK : Form
    {
        public HuyVeforHK()
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn muốn trở lại?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                Dich_vu dv = new Dich_vu();
                dv.Show();
                this.Hide();
            }
        }
        string strConnectionString = @"Data Source=(local);Initial Catalog=QUAN_LI_CHUYEN_BAY;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTABLENAME
        SqlDataAdapter daTABLENAME = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtTABLENAME = null;

        void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from VE where CMND_HK = "+txtCMND.Text+"", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
            dataGridView1.DataSource = dtTABLENAME;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = conn;

                cmd.CommandType = CommandType.Text;
                // Thứ tự dòng hiện hành

                int r = dataGridView1.CurrentCell.RowIndex;// Ma hiện hành
                string strMave = dataGridView1.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh SQL

                cmd.CommandText = "DELETE FROM VE WHERE MaVe ='"+strMave+"'";
                // Cập nhật
                cmd.ExecuteNonQuery();

                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã hủy xong!");
            }

            catch (SqlException)
            {

                MessageBox.Show(cmd.CommandText);// "Không sửa được. Lỗi rồi!");
            }
            // Đóng kết nối         
            conn.Close();
        }

        private void HuyVeforHK_Load(object sender, EventArgs e)
        {

        }
    }
}
