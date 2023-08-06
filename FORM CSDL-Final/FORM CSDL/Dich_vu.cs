using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_CSDL
{
    public partial class Dich_vu : Form
    {
        public Dich_vu()
        {
            InitializeComponent();
        }

        private void dangxuat_Click(object sender, EventArgs e)
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

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void tt_Click(object sender, EventArgs e)
        {
            ThemThongTin ttt = new ThemThongTin();
            ttt.Show();
            this.Hide();
        }

        private void ve_Click(object sender, EventArgs e)
        {
            Mua_Ve muave = new Mua_Ve();
            muave.Show();
            this.Hide();
        }

        private void xtt_Click(object sender, EventArgs e)
        {
            Xem_vs_sua_inf4_KH xstt = new Xem_vs_sua_inf4_KH();
            xstt.Show();
            this.Hide();
        }

        private void huyve_Click(object sender, EventArgs e)
        {
            HuyVeforHK hv = new HuyVeforHK();
            hv.Show();
            this.Hide();
        }

        private void Dich_vu_Load(object sender, EventArgs e)
        {

        }
    }
}
