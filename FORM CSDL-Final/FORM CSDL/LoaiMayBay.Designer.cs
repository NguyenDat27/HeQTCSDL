namespace FORM_CSDL
{
    partial class LoaiMayBay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MaLoaiMayBay = new System.Windows.Forms.TextBox();
            this.textBox_HangSX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 391);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(198, 391);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Sửa";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(436, 391);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 3;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(634, 391);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Loại Máy Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hãng sản xuất";
            // 
            // textBox_MaLoaiMayBay
            // 
            this.textBox_MaLoaiMayBay.Location = new System.Drawing.Point(634, 113);
            this.textBox_MaLoaiMayBay.Name = "textBox_MaLoaiMayBay";
            this.textBox_MaLoaiMayBay.Size = new System.Drawing.Size(100, 22);
            this.textBox_MaLoaiMayBay.TabIndex = 7;
            // 
            // textBox_HangSX
            // 
            this.textBox_HangSX.Location = new System.Drawing.Point(634, 208);
            this.textBox_HangSX.Name = "textBox_HangSX";
            this.textBox_HangSX.Size = new System.Drawing.Size(100, 22);
            this.textBox_HangSX.TabIndex = 8;
            // 
            // LoaiMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_HangSX);
            this.Controls.Add(this.textBox_MaLoaiMayBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LoaiMayBay";
            this.Text = "LoaiMayBay";
            this.Load += new System.EventHandler(this.LoaiMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MaLoaiMayBay;
        private System.Windows.Forms.TextBox textBox_HangSX;
    }
}