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
    public partial class TaoTK_MK : Form
    {
        public TaoTK_MK()
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
        void loadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daTABLENAME = new SqlDataAdapter("SELECT * FROM dn_hk", conn);
                dtTABLENAME = new DataTable();
                daTABLENAME.Fill(dtTABLENAME);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng dn_hk", "Lỗi dữ liệu!");
            }
        }
        private void TaoTK_MK_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn muốn trở lại Login?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                TrangPhanQuyen tpq = new TrangPhanQuyen();
                tpq.Show();
                this.Hide();
            }
        }

        private void tt_Click(object sender, EventArgs e)
        {
            loadData();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            if (MK.Text == MK2.Text)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Viết câu lệnh SQL
                    cmd.CommandText = "INSERT INTO dn_hk VALUES('" + TK.Text + "','" + MK.Text + "')";
                    cmd.ExecuteNonQuery();
                    loadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                    TrangPhanQuyen hk = new TrangPhanQuyen();
                    hk.Show();
                    this.Hide();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!!!");
                    MessageBox.Show(ex.Message.ToString());
                }
                // Đóng kết nối
                conn.Close();
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu sai!");
            }
        }

        private void TaoTK_MK_Load_1(object sender, EventArgs e)
        {

        }
    }
}
