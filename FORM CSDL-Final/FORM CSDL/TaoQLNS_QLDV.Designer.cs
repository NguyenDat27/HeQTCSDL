
namespace FORM_CSDL
{
    partial class TaoQLNS_QLDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtPQ = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chinhsua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.doiMK = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(332, 168);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(301, 26);
            this.txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(332, 249);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(301, 26);
            this.txtMK.TabIndex = 1;
            // 
            // txtPQ
            // 
            this.txtPQ.Location = new System.Drawing.Point(332, 340);
            this.txtPQ.Name = "txtPQ";
            this.txtPQ.Size = new System.Drawing.Size(301, 26);
            this.txtPQ.TabIndex = 2;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(48, 438);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(133, 60);
            this.them.TabIndex = 3;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tai Khoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mat Khau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phan Quyen";
            // 
            // chinhsua
            // 
            this.chinhsua.AutoSize = true;
            this.chinhsua.Location = new System.Drawing.Point(353, 438);
            this.chinhsua.Name = "chinhsua";
            this.chinhsua.Size = new System.Drawing.Size(137, 60);
            this.chinhsua.TabIndex = 7;
            this.chinhsua.Text = "Chỉnh sửa quyền";
            this.chinhsua.UseVisualStyleBackColor = true;
            this.chinhsua.Click += new System.EventHandler(this.chinhsua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(529, 438);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(133, 60);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // doiMK
            // 
            this.doiMK.Location = new System.Drawing.Point(198, 438);
            this.doiMK.Name = "doiMK";
            this.doiMK.Size = new System.Drawing.Size(133, 60);
            this.doiMK.TabIndex = 9;
            this.doiMK.Text = "Đổi mật khẩu";
            this.doiMK.UseVisualStyleBackColor = true;
            this.doiMK.Click += new System.EventHandler(this.doiMK_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(693, 438);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(133, 60);
            this.thoat.TabIndex = 10;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // TaoQLNS_QLDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 575);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.doiMK);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.chinhsua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txtPQ);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Name = "TaoQLNS_QLDV";
            this.Text = "TaoQLNS_QLDV";
            this.Load += new System.EventHandler(this.TaoQLNS_QLDV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtPQ;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chinhsua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button doiMK;
        private System.Windows.Forms.Button thoat;
    }
}