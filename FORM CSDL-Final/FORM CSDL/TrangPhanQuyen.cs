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
    public partial class TrangPhanQuyen : Form
    {
        public TrangPhanQuyen()
        {
            InitializeComponent();
        }
        bool check_admin_user;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check_admin_user = true;
            dangki.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check_admin_user = false;
            dangki.Enabled = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source = (local); Initial Catalog = QUAN_LI_CHUYEN_BAY; Integrated Security = True";
            SqlConnection conn = null;
            if (check_admin_user)
            {
                try
                {
                    conn = new SqlConnection(connstr);
                    conn.Open();
                    string tk = TaiKhoan.Text;
                    string mk = MatKhau.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM dn_admin WHERE TKadmin = '" + tk + "' AND MKadmin ='" + mk + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Quan_li ql = new Quan_li();
                        ql.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không kết nối được tới admin", "Lỗi dữ liệu!");
                }
            }
            else
            {
                try
                {
                    conn = new SqlConnection(connstr);
                    conn.Open();
                    string tk = TaiKhoan.Text;
                    string mk = MatKhau.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM dn_hk WHERE TKhk = '" + tk + "' AND MKhk ='" + mk + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dich_vu dv = new Dich_vu();
                        dv.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không kết nối được tới user", "Lỗi dữ liệu!");
                }
            }
        }

        private void Mo_Click(object sender, EventArgs e)
        {
            if (MatKhau.PasswordChar == '\0')
            {
                Dong.BringToFront();
                MatKhau.PasswordChar = '*';
            }
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            if (MatKhau.PasswordChar == '*')
            {
                Mo.BringToFront();
                MatKhau.PasswordChar = '\0';
            }
        }

        private void TrangPhanQuyen_Load(object sender, EventArgs e)
        {
            dangki.Enabled = false;
        }

        private void dangki_Click(object sender, EventArgs e)
        {
            TaoTK_MK tkmk = new TaoTK_MK();
            tkmk.Show();
            this.Hide();
        }
    }
}
