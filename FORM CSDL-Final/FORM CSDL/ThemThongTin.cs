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
    public partial class ThemThongTin : Form
    {
        public ThemThongTin()
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
        void LoadData()
        {
            btSave.Enabled = false;
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu vào DataTable dtThanhPho

                dtTABLENAME = new DataTable();
                dtTABLENAME.Clear();
                daTABLENAME.Fill(dtTABLENAME);
                // Đưa dữ liệu lên DataGridViewLưu hành nội bộ Trang 78
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
                Dich_vu dv = new Dich_vu();
                dv.Show();
                this.Hide();
            }
        }
        private void Hanh_khach_Load(object sender, EventArgs e)
        {
            btSave.Enabled = false;
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from HANHKHACH", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
        }
        private void button_save_Click(object sender, EventArgs e)
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
                System.String.Concat("EXEC Insert_HanhKhach'" + txtCCCD.Text + "','"
                + txtHT.Text + "','" + dtNS.Text + "','" + txtDC.Text + "','" + txtSDT.Text + "'"
                );

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã thêm xong!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
            // Đóng kết nối
            conn.Close();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }
    }
}
