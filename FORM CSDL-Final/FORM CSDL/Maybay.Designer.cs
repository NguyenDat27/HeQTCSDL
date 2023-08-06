namespace FORM_CSDL
{
    partial class Maybay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.text_sohieu = new System.Windows.Forms.TextBox();
            this.text_maloaimaybay = new System.Windows.Forms.TextBox();
            this.text_ghetrong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã loại máy bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số ghế trống";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(257, 377);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Sửa";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(490, 377);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Xóa";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(28, 377);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(713, 377);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(75, 23);
            this.button_EXIT.TabIndex = 7;
            this.button_EXIT.Text = "Thoát";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // text_sohieu
            // 
            this.text_sohieu.Location = new System.Drawing.Point(646, 69);
            this.text_sohieu.Name = "text_sohieu";
            this.text_sohieu.Size = new System.Drawing.Size(100, 22);
            this.text_sohieu.TabIndex = 8;
            // 
            // text_maloaimaybay
            // 
            this.text_maloaimaybay.Location = new System.Drawing.Point(646, 152);
            this.text_maloaimaybay.Name = "text_maloaimaybay";
            this.text_maloaimaybay.Size = new System.Drawing.Size(100, 22);
            this.text_maloaimaybay.TabIndex = 9;
            // 
            // text_ghetrong
            // 
            this.text_ghetrong.Location = new System.Drawing.Point(646, 227);
            this.text_ghetrong.Name = "text_ghetrong";
            this.text_ghetrong.Size = new System.Drawing.Size(100, 22);
            this.text_ghetrong.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 230);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // Maybay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_ghetrong);
            this.Controls.Add(this.text_maloaimaybay);
            this.Controls.Add(this.text_sohieu);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Maybay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maybay";
            this.Load += new System.EventHandler(this.Maybay_Load);
            this.DoubleClick += new System.EventHandler(this.Maybay_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.TextBox text_sohieu;
        private System.Windows.Forms.TextBox text_maloaimaybay;
        private System.Windows.Forms.TextBox text_ghetrong;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}