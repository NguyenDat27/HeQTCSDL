namespace FORM_CSDL
{
    partial class Loc_ds_chuyen_bay
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_maCB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_begin = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MaCB";
            // 
            // text_maCB
            // 
            this.text_maCB.Location = new System.Drawing.Point(171, 44);
            this.text_maCB.Name = "text_maCB";
            this.text_maCB.Size = new System.Drawing.Size(100, 22);
            this.text_maCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daybegin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dayend";
            // 
            // date_begin
            // 
            this.date_begin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.date_begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_begin.Location = new System.Drawing.Point(171, 97);
            this.date_begin.Name = "date_begin";
            this.date_begin.Size = new System.Drawing.Size(200, 22);
            this.date_begin.TabIndex = 5;
            // 
            // date_end
            // 
            this.date_end.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_end.Location = new System.Drawing.Point(171, 145);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(200, 22);
            this.date_end.TabIndex = 6;
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(713, 415);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(75, 23);
            this.button_filter.TabIndex = 9;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(713, 347);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(75, 23);
            this.button_EXIT.TabIndex = 10;
            this.button_EXIT.Text = "EXIT";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // Loc_ds_chuyen_bay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.date_begin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_maCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Loc_ds_chuyen_bay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loc_ds_chuyen_bay";
            this.Load += new System.EventHandler(this.Loc_ds_chuyen_bay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_maCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_begin;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_EXIT;
    }
}