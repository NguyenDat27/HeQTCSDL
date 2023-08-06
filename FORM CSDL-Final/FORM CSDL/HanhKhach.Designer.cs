namespace FORM_CSDL
{
    partial class Hanh_khach
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_sinh = new System.Windows.Forms.DateTimePicker();
            this.text_dia_chi = new System.Windows.Forms.TextBox();
            this.text_sdt = new System.Windows.Forms.TextBox();
            this.text_Hoten = new System.Windows.Forms.TextBox();
            this.text_CMND = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(415, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(60, 458);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(84, 29);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CMND";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(282, 458);
            this.button_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(84, 29);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Sửa";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(487, 458);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(84, 29);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Xoa";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(688, 458);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(84, 29);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "ngày sinh";
            // 
            // date_sinh
            // 
            this.date_sinh.CustomFormat = "yyyy-MM-dd ";
            this.date_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_sinh.Location = new System.Drawing.Point(610, 214);
            this.date_sinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_sinh.Name = "date_sinh";
            this.date_sinh.Size = new System.Drawing.Size(224, 26);
            this.date_sinh.TabIndex = 11;
            // 
            // text_dia_chi
            // 
            this.text_dia_chi.Location = new System.Drawing.Point(610, 274);
            this.text_dia_chi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_dia_chi.Name = "text_dia_chi";
            this.text_dia_chi.Size = new System.Drawing.Size(224, 26);
            this.text_dia_chi.TabIndex = 12;
            // 
            // text_sdt
            // 
            this.text_sdt.Location = new System.Drawing.Point(610, 346);
            this.text_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_sdt.Name = "text_sdt";
            this.text_sdt.Size = new System.Drawing.Size(224, 26);
            this.text_sdt.TabIndex = 13;
            // 
            // text_Hoten
            // 
            this.text_Hoten.Location = new System.Drawing.Point(610, 129);
            this.text_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_Hoten.Name = "text_Hoten";
            this.text_Hoten.Size = new System.Drawing.Size(224, 26);
            this.text_Hoten.TabIndex = 14;
            this.text_Hoten.TextChanged += new System.EventHandler(this.textB_Hoten_TextChanged);
            // 
            // text_CMND
            // 
            this.text_CMND.Location = new System.Drawing.Point(610, 65);
            this.text_CMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_CMND.Name = "text_CMND";
            this.text_CMND.Size = new System.Drawing.Size(224, 26);
            this.text_CMND.TabIndex = 15;
            // 
            // Hanh_khach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.text_CMND);
            this.Controls.Add(this.text_Hoten);
            this.Controls.Add(this.text_sdt);
            this.Controls.Add(this.text_dia_chi);
            this.Controls.Add(this.date_sinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Hanh_khach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanh Khach";
            this.Load += new System.EventHandler(this.Hanh_khach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_sinh;
        private System.Windows.Forms.TextBox text_dia_chi;
        private System.Windows.Forms.TextBox text_sdt;
        private System.Windows.Forms.TextBox text_Hoten;
        private System.Windows.Forms.TextBox text_CMND;
    }
}

