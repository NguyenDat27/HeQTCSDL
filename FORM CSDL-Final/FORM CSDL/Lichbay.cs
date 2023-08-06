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
    public partial class Lichbay : Form
    {
        // Chuỗi kết nối
        string strConnectionString = @"Data Source=(local);Initial Catalog=QUAN_LI_CHUYEN_BAY;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTABLENAME
        SqlDataAdapter daTABLENAME = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtTABLENAME = null;
        public Lichbay()
        {
            InitializeComponent();
        }

       
        private void Lichbay_Load(object sender, EventArgs e)
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTABLENAME
            daTABLENAME = new SqlDataAdapter("Select * from Lichbay", conn);
            dtTABLENAME = new DataTable();
            daTABLENAME.Fill(dtTABLENAME);
            dataGridView1.DataSource = dtTABLENAME;
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SoHieu_Click(object sender, EventArgs e)
        {

        }

        private void So_ghe_trong_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void trang_thai_bay_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
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
                string s = $"EXEC AddLichBay  '{text_MaCB.Text}',   " +
                    $"'{text_SoHieu.Text}', '{date_cat_canh.Text}'," +
                    $"  '{date_ha_canh.Text}',  '{combo_sanbaydi.Text}', " +
                    $" '{comboBo_sanbayden.Text}'," +
                    $"'{comboBox_trang_thai_bay.Text}'," +
                    $"  '{text_MaPC.Text}' ";
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

        private void update_Click(object sender, EventArgs e)
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
                string s = $"EXEC  UpdateLichBay '{text_MaCB.Text}',   " +
                    $"'{text_SoHieu.Text}', '{date_cat_canh.Text}'," +
                    $"  '{date_ha_canh.Text}',  '{combo_sanbaydi.Text}', " +
                    $" '{comboBo_sanbayden.Text}'," +
                    $"'{comboBox_trang_thai_bay.Text}'," +
                    $"  '{text_MaPC.Text}' ";
                cmd.CommandText =
                System.String.Concat(s);

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hien_thi();
        }
        void hien_thi()
        {
            int r = dataGridView1.CurrentCell.RowIndex;
 
            this.text_MaCB.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.text_SoHieu.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.date_cat_canh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.date_ha_canh.Text= dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.combo_sanbaydi.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            this.comboBo_sanbayden.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            this.comboBox_trang_thai_bay.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            this.text_ghe_trong.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            this.text_MaPC.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
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
                MessageBox.Show("Không lấy được nội dung .Lỗi rồi!!!");
            }
        }
        void reset()
        {
            this.text_MaCB.Clear();
            this.text_SoHieu.Clear();
            this.date_cat_canh.ResetText();
            this.date_ha_canh.ResetText();
            this.combo_sanbaydi.Items.Clear();
            this.comboBo_sanbayden.Items.Clear();
            this.comboBox_trang_thai_bay.Items.Clear();
            this.text_ghe_trong.Clear();
            this.text_MaPC.Clear();
            this.text_MaCB.Focus();
        }
        private void date_cat_canh_ValueChanged(object sender, EventArgs e)
        {

        }
        
            private void delete_Click(object sender, EventArgs e)
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
                cmd.CommandText = 
                    System.String.Concat("EXEC DeleteLichBay '"+this.text_MaCB.Text+ "','"+this.date_cat_canh.Text+ "' ,'"+this.date_ha_canh.Text+ "'");
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
    }
}
