namespace FORM_CSDL
{
    partial class Tinhtrangchuyenbay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date_begin = new System.Windows.Forms.DateTimePicker();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.button_Loc = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ TÌNH TRANGJBAY CÁC CHUYẾN TÙ NGÀY X ĐẾN NGÀY Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // date_begin
            // 
            this.date_begin.CustomFormat = "yyyy-MM-dd ";
            this.date_begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_begin.Location = new System.Drawing.Point(174, 122);
            this.date_begin.Name = "date_begin";
            this.date_begin.Size = new System.Drawing.Size(200, 22);
            this.date_begin.TabIndex = 6;
            // 
            // dateTime_end
            // 
            this.dateTime_end.CustomFormat = "yyyy-MM-dd ";
            this.dateTime_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_end.Location = new System.Drawing.Point(575, 117);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.Size = new System.Drawing.Size(200, 22);
            this.dateTime_end.TabIndex = 7;
            // 
            // button_Loc
            // 
            this.button_Loc.Location = new System.Drawing.Point(126, 391);
            this.button_Loc.Name = "button_Loc";
            this.button_Loc.Size = new System.Drawing.Size(75, 23);
            this.button_Loc.TabIndex = 8;
            this.button_Loc.Text = "filter";
            this.button_Loc.UseVisualStyleBackColor = true;
            this.button_Loc.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(575, 391);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(75, 23);
            this.button_EXIT.TabIndex = 9;
            this.button_EXIT.Text = "EXIT";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // Tinhtrangchuyenbay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_Loc);
            this.Controls.Add(this.dateTime_end);
            this.Controls.Add(this.date_begin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tinhtrangchuyenbay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tinhtrangchuyenbay";
            this.Load += new System.EventHandler(this.Tinhtrangchuyenbay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker date_begin;
        private System.Windows.Forms.DateTimePicker dateTime_end;
        private System.Windows.Forms.Button button_Loc;
        private System.Windows.Forms.Button button_EXIT;
    }
}