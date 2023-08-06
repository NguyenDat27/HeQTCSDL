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
    public partial class Mua_Ve : Form
    {
        public Mua_Ve()
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mua_Ve_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                Dich_vu ql = new Dich_vu();
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
                // Đưa dữ liệu lên DataGridViewLưu hành nội bộ 
                dataGridView1.DataSource = dtTABLENAME;
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung .Lỗi rồi!!!");
            }
        }
        
        void hien_thi_foi_y()
        {

            int r = dataGridView1.CurrentCell.RowIndex;
            this.text_MaCB.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.date_catcanh.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.date_hacanh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
           
        }
        void reset()
        {
            this.textBox_CMND.Clear();
            this.textBox_Soghe.Clear();
            this.date_can_bay.ResetText();
            this.date_catcanh.ResetText();
            this.date_hacanh.Clear();
            this.comboBox_noiden.Items.Clear();
            this.comboBox_noidi.Items.Clear();
            this.combo_giave.Items.Clear();
            this.textBox_Soghe.Clear();
            this.textBox_CMND.Focus();  
            
        }
        private void button3_Click(object sender, EventArgs e)
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
                string s = $"EXEC proc_insert_Ve '{this.textBox_CMND.Text}'," +
                    $"'{this.text_MaCB.Text}','{this.date_catcanh.Text}','{this.date_hacanh.Text}','{this.date_can_bay.Text}'," +
                    $"'{this.comboBox_noidi.Text}','{this.comboBox_noiden.Text}'," +
                    $"{int.Parse(this.textBox_Soghe.Text)},{float.Parse(this.combo_giave.Text)}";


                cmd.CommandText =
                System.String.Concat(s

                );

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã mua xong!");
                reset();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không them được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
            // Đóng kết nối

            reset();



            conn.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            hien_thi_foi_y();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtTABLENAME
                string s = $"EXEC proc_goi_y_chuyen_bay '{this.date_can_bay.Text}','{this.comboBox_noidi.Text}','{this.comboBox_noiden.Text}'";
                daTABLENAME = new SqlDataAdapter(s, conn);
                dtTABLENAME = new DataTable();
                daTABLENAME.Fill(dtTABLENAME);
                dataGridView1.DataSource = dtTABLENAME;
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lọc được. Lỗi rồi!!!");
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
