namespace FORM_CSDL
{
    partial class Lichbay
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
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.MaCB = new System.Windows.Forms.Label();
            this.tg_cat_canh = new System.Windows.Forms.Label();
            this.SoHieu = new System.Windows.Forms.Label();
            this.tg_ha_canh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaPC = new System.Windows.Forms.Label();
            this.So_ghe_trong = new System.Windows.Forms.Label();
            this.text_MaCB = new System.Windows.Forms.TextBox();
            this.text_SoHieu = new System.Windows.Forms.TextBox();
            this.text_MaPC = new System.Windows.Forms.TextBox();
            this.text_ghe_trong = new System.Windows.Forms.TextBox();
            this.comboBo_sanbayden = new System.Windows.Forms.ComboBox();
            this.combo_sanbaydi = new System.Windows.Forms.ComboBox();
            this.date_cat_canh = new System.Windows.Forms.DateTimePicker();
            this.date_ha_canh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_trang_thai_bay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(88, 436);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(363, 436);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 3;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(747, 436);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(1073, 436);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Thoat";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // MaCB
            // 
            this.MaCB.AutoSize = true;
            this.MaCB.Location = new System.Drawing.Point(646, 87);
            this.MaCB.Name = "MaCB";
            this.MaCB.Size = new System.Drawing.Size(44, 16);
            this.MaCB.TabIndex = 6;
            this.MaCB.Text = "MaCB";
            // 
            // tg_cat_canh
            // 
            this.tg_cat_canh.AutoSize = true;
            this.tg_cat_canh.Location = new System.Drawing.Point(893, 90);
            this.tg_cat_canh.Name = "tg_cat_canh";
            this.tg_cat_canh.Size = new System.Drawing.Size(107, 16);
            this.tg_cat_canh.TabIndex = 7;
            this.tg_cat_canh.Text = "Thoigiancatcanh";
            // 
            // SoHieu
            // 
            this.SoHieu.AutoSize = true;
            this.SoHieu.Location = new System.Drawing.Point(646, 155);
            this.SoHieu.Name = "SoHieu";
            this.SoHieu.Size = new System.Drawing.Size(55, 16);
            this.SoHieu.TabIndex = 8;
            this.SoHieu.Text = "So Hieu";
            this.SoHieu.Click += new System.EventHandler(this.SoHieu_Click);
            // 
            // tg_ha_canh
            // 
            this.tg_ha_canh.AutoSize = true;
            this.tg_ha_canh.Location = new System.Drawing.Point(893, 159);
            this.tg_ha_canh.Name = "tg_ha_canh";
            this.tg_ha_canh.Size = new System.Drawing.Size(104, 16);
            this.tg_ha_canh.TabIndex = 9;
            this.tg_ha_canh.Text = "Thoigianhacanh";
            this.tg_ha_canh.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(914, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "San bay di";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(926, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "San bay den";
            // 
            // MaPC
            // 
            this.MaPC.AutoSize = true;
            this.MaPC.Location = new System.Drawing.Point(646, 220);
            this.MaPC.Name = "MaPC";
            this.MaPC.Size = new System.Drawing.Size(44, 16);
            this.MaPC.TabIndex = 12;
            this.MaPC.Text = "MaPC";
            // 
            // So_ghe_trong
            // 
            this.So_ghe_trong.AutoSize = true;
            this.So_ghe_trong.Location = new System.Drawing.Point(646, 283);
            this.So_ghe_trong.Name = "So_ghe_trong";
            this.So_ghe_trong.Size = new System.Drawing.Size(91, 16);
            this.So_ghe_trong.TabIndex = 14;
            this.So_ghe_trong.Text = "So_ghe_trong";
            this.So_ghe_trong.Click += new System.EventHandler(this.So_ghe_trong_Click);
            // 
            // text_MaCB
            // 
            this.text_MaCB.Location = new System.Drawing.Point(747, 87);
            this.text_MaCB.Name = "text_MaCB";
            this.text_MaCB.Size = new System.Drawing.Size(122, 22);
            this.text_MaCB.TabIndex = 15;
            // 
            // text_SoHieu
            // 
            this.text_SoHieu.Location = new System.Drawing.Point(747, 155);
            this.text_SoHieu.Name = "text_SoHieu";
            this.text_SoHieu.Size = new System.Drawing.Size(122, 22);
            this.text_SoHieu.TabIndex = 22;
            // 
            // text_MaPC
            // 
            this.text_MaPC.Location = new System.Drawing.Point(747, 220);
            this.text_MaPC.Name = "text_MaPC";
            this.text_MaPC.Size = new System.Drawing.Size(122, 22);
            this.text_MaPC.TabIndex = 23;
            // 
            // text_ghe_trong
            // 
            this.text_ghe_trong.Location = new System.Drawing.Point(747, 277);
            this.text_ghe_trong.Name = "text_ghe_trong";
            this.text_ghe_trong.ReadOnly = true;
            this.text_ghe_trong.Size = new System.Drawing.Size(122, 22);
            this.text_ghe_trong.TabIndex = 24;
            // 
            // comboBo_sanbayden
            // 
            this.comboBo_sanbayden.FormattingEnabled = true;
            this.comboBo_sanbayden.Items.AddRange(new object[] {
            "HCM",
            "Ha Noi",
            "Da Nang"});
            this.comboBo_sanbayden.Location = new System.Drawing.Point(1023, 266);
            this.comboBo_sanbayden.Name = "comboBo_sanbayden";
            this.comboBo_sanbayden.Size = new System.Drawing.Size(250, 24);
            this.comboBo_sanbayden.TabIndex = 26;
            // 
            // combo_sanbaydi
            // 
            this.combo_sanbaydi.FormattingEnabled = true;
            this.combo_sanbaydi.Items.AddRange(new object[] {
            "HCM",
            "Ha Noi",
            "Da Nang"});
            this.combo_sanbaydi.Location = new System.Drawing.Point(1023, 205);
            this.combo_sanbaydi.Name = "combo_sanbaydi";
            this.combo_sanbaydi.Size = new System.Drawing.Size(250, 24);
            this.combo_sanbaydi.TabIndex = 27;
            //this.combo_sanbaydi.SelectedIndexChanged += new System.EventHandler(this.combo_sanbaydi_SelectedIndexChanged);
            // 
            // date_cat_canh
            // 
            this.date_cat_canh.CustomFormat = "yyyy-MM-dd HH:mm";
            this.date_cat_canh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_cat_canh.Location = new System.Drawing.Point(997, 85);
            this.date_cat_canh.Name = "date_cat_canh";
            this.date_cat_canh.Size = new System.Drawing.Size(276, 22);
            this.date_cat_canh.TabIndex = 28;
            this.date_cat_canh.ValueChanged += new System.EventHandler(this.date_cat_canh_ValueChanged);
            // 
            // date_ha_canh
            // 
            this.date_ha_canh.CustomFormat = " yyyy-MM-dd HH:mm";
            this.date_ha_canh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ha_canh.Location = new System.Drawing.Point(1023, 153);
            this.date_ha_canh.Name = "date_ha_canh";
            this.date_ha_canh.Size = new System.Drawing.Size(250, 22);
            this.date_ha_canh.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Trang thai bay";
            // 
            // comboBox_trang_thai_bay
            // 
            this.comboBox_trang_thai_bay.FormattingEnabled = true;
            this.comboBox_trang_thai_bay.Items.AddRange(new object[] {
            "landing",
            "flying",
            "take off",
            "delay",
            "cancel",
            "NULL"});
            this.comboBox_trang_thai_bay.Location = new System.Drawing.Point(749, 344);
            this.comboBox_trang_thai_bay.Name = "comboBox_trang_thai_bay";
            this.comboBox_trang_thai_bay.Size = new System.Drawing.Size(121, 24);
            this.comboBox_trang_thai_bay.TabIndex = 31;
            // 
            // Lichbay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 490);
            this.Controls.Add(this.comboBox_trang_thai_bay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_ha_canh);
            this.Controls.Add(this.date_cat_canh);
            this.Controls.Add(this.combo_sanbaydi);
            this.Controls.Add(this.comboBo_sanbayden);
            this.Controls.Add(this.text_ghe_trong);
            this.Controls.Add(this.text_MaPC);
            this.Controls.Add(this.text_SoHieu);
            this.Controls.Add(this.text_MaCB);
            this.Controls.Add(this.So_ghe_trong);
            this.Controls.Add(this.MaPC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tg_ha_canh);
            this.Controls.Add(this.SoHieu);
            this.Controls.Add(this.tg_cat_canh);
            this.Controls.Add(this.MaCB);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lichbay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lich bay";
            this.Load += new System.EventHandler(this.Lichbay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label MaCB;
        private System.Windows.Forms.Label tg_cat_canh;
        private System.Windows.Forms.Label SoHieu;
        private System.Windows.Forms.Label tg_ha_canh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MaPC;
        private System.Windows.Forms.Label So_ghe_trong;
        private System.Windows.Forms.TextBox text_MaCB;
        private System.Windows.Forms.TextBox text_SoHieu;
        private System.Windows.Forms.TextBox text_MaPC;
        private System.Windows.Forms.TextBox text_ghe_trong;
        private System.Windows.Forms.ComboBox comboBo_sanbayden;
        private System.Windows.Forms.ComboBox combo_sanbaydi;
        private System.Windows.Forms.DateTimePicker date_cat_canh;
        private System.Windows.Forms.DateTimePicker date_ha_canh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_trang_thai_bay;
    }
}

