
namespace FORM_CSDL
{
    partial class XemPhanQuyen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPQ = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.ktdn = new System.Windows.Forms.Button();
            this.ktpq = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phan Quyen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mat Khau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tai Khoan";
            // 
            // txtPQ
            // 
            this.txtPQ.Location = new System.Drawing.Point(152, 238);
            this.txtPQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPQ.Name = "txtPQ";
            this.txtPQ.Size = new System.Drawing.Size(268, 22);
            this.txtPQ.TabIndex = 9;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(152, 166);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(268, 22);
            this.txtMK.TabIndex = 8;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(152, 101);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(268, 22);
            this.txtTK.TabIndex = 7;
            // 
            // ktdn
            // 
            this.ktdn.AutoSize = true;
            this.ktdn.Location = new System.Drawing.Point(181, 337);
            this.ktdn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ktdn.Name = "ktdn";
            this.ktdn.Size = new System.Drawing.Size(140, 58);
            this.ktdn.TabIndex = 13;
            this.ktdn.Text = "Kiểm tra đăng nhập";
            this.ktdn.UseVisualStyleBackColor = true;
            this.ktdn.Click += new System.EventHandler(this.ktdn_Click);
            // 
            // ktpq
            // 
            this.ktpq.AutoSize = true;
            this.ktpq.Location = new System.Drawing.Point(380, 337);
            this.ktpq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ktpq.Name = "ktpq";
            this.ktpq.Size = new System.Drawing.Size(164, 58);
            this.ktpq.TabIndex = 14;
            this.ktpq.Text = "Kiểm tra phân quyền";
            this.ktpq.UseVisualStyleBackColor = true;
            this.ktpq.Click += new System.EventHandler(this.ktpq_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(458, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(313, 234);
            this.dataGridView1.TabIndex = 15;
            // 
            // thoat
            // 
            this.thoat.AutoSize = true;
            this.thoat.Location = new System.Drawing.Point(576, 337);
            this.thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(108, 58);
            this.thoat.TabIndex = 16;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // XemPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 457);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ktpq);
            this.Controls.Add(this.ktdn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPQ);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XemPhanQuyen";
            this.Text = "XemPhanQuyen";
            this.Load += new System.EventHandler(this.XemPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPQ;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button ktdn;
        private System.Windows.Forms.Button ktpq;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button thoat;
    }
}