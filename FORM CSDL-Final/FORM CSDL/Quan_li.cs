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
    public partial class Quan_li : Form
    {
        public Quan_li()
        {
            InitializeComponent();
        }

        private void hk_Click(object sender, EventArgs e)
        {
            Hanh_khach hk = new Hanh_khach();
            hk.Show();
            this.Hide();
        }

        private void lb_Click(object sender, EventArgs e)
        {
            Lichbay lb = new Lichbay();
            lb.Show();
            this.Hide();
        }

        private void lmb_Click(object sender, EventArgs e)
        {
            LoaiMayBay lmb = new LoaiMayBay();
            lmb.Show();
            this.Hide();
        }

        private void mb_Click(object sender, EventArgs e)
        {
            Maybay mb = new Maybay();
            mb.Show();
            this.Hide();
        }

        private void ve_Click(object sender, EventArgs e)
        {
            Ve_for_admin ve = new Ve_for_admin();
            ve.Show();
            this.Hide();
        }

        private void loc_Click(object sender, EventArgs e)
        {
            Loc_ds_chuyen_bay loc = new Loc_ds_chuyen_bay();
            loc.Show();
            this.Hide();
        }

        private void slv_Click(object sender, EventArgs e)
        {
            Sl_Ve_moi_thang slv = new Sl_Ve_moi_thang();
            slv.Show();
            this.Hide();
        }

        private void ttcb_Click(object sender, EventArgs e)
        {
            Tinhtrangchuyenbay ttcb = new Tinhtrangchuyenbay();
            ttcb.Show();
            this.Hide();
        }

        private void tsmb_Click(object sender, EventArgs e)
        {
            Tong_so_MB tsmb = new Tong_so_MB();
            tsmb.Show();
            this.Hide();
        }

        private void tkl_Click(object sender, EventArgs e)
        {
            thongke_luong_PC tkl = new thongke_luong_PC();
            tkl.Show();
            this.Hide();
        }

        private void tkmb_Click(object sender, EventArgs e)
        {
            Thongke_SLMB__moiloai tkmb = new Thongke_SLMB__moiloai();
            tkmb.Show();
            this.Hide();
        }
        private void pc_Click(object sender, EventArgs e)
        {
            PhiCong pc = new PhiCong();
            pc.Show();
            this.Hide();
        }
        private void kn_Click(object sender, EventArgs e)
        {
            KhaNang kn = new KhaNang();
            kn.Show();
            this.Hide();
        }
        private void dangsuat_Click(object sender, EventArgs e)
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

        private void Quan_li_Load(object sender, EventArgs e)
        {

        }

        private void pq_Click(object sender, EventArgs e)
        {
            TaoQLNS_QLDV tv = new TaoQLNS_QLDV();
            tv.Show();
            this.Hide();
        }

        private void xpq_Click(object sender, EventArgs e)
        {
            XemPhanQuyen xpq = new XemPhanQuyen();
            xpq.Show();
            this.Hide();
        }
    }
}
