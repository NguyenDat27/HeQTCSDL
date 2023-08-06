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
    public partial class Xem_vs_sua_inf4_KH : Form
    {
        public Xem_vs_sua_inf4_KH()
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
        private void Xem_vs_sua_inf4_KH_Load(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            // Mở kết nối
            if (textBox_CMND.Text!="" )
            {
                try
                {
                    conn = new SqlConnection(strConnectionString);
                    string s = $"select * from HANHKHACH where CMND_HK='{this.textBox_CMND.Text}'";
                    // Vận chuyển dữ liệu lên DataTable dtTABLENAME
                    daTABLENAME = new SqlDataAdapter(s, conn);
                    dtTABLENAME = new DataTable();
                    daTABLENAME.Fill(dtTABLENAME);
                    dataGridView1.DataSource = dtTABLENAME;




                    MessageBox.Show("Đã tim thay xong!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không tim  được. Lỗi rồi!!!");
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        
        }

        
        void Reset()
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            this.textBox_CMND.ResetText();
            this.textBox_Hoten.ResetText();
            this.date_sinh.ResetText();
            this.textBox_Diachi.ResetText();
            this.textBox_SDT.ResetText();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int test = 0;
            textBox_CMND.Enabled = true;
            textBox_Hoten.Enabled = true;
            textBox_Diachi.Enabled = true;
            textBox_SDT.Enabled = true;
            date_sinh.Enabled = true;
           
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
                System.String.Concat("EXEC Update_HanhKhach'" +textBox_CMND.Text + "','"
                + textBox_Hoten.Text + "','" + date_sinh.Text + "','" + textBox_Diachi.Text + "','" + textBox_SDT.Text + "'"

                );

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                hien_thi();
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
        void hien_thi()
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            this.textBox_CMND.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.textBox_Hoten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.date_sinh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.textBox_Diachi.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.textBox_SDT.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView1.DataSource = null;


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
                Dich_vu ql = new Dich_vu();
                ql.Show();
                this.Hide();
            }
        }

        private void date_ngay_sinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            hien_thi();
        }

        private void textBox_Hoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
