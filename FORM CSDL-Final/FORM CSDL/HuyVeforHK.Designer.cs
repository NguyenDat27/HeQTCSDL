
namespace FORM_CSDL
{
    partial class HuyVeforHK
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
            this.huy = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(303, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // huy
            // 
            this.huy.AutoSize = true;
            this.huy.Location = new System.Drawing.Point(392, 285);
            this.huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(116, 50);
            this.huy.TabIndex = 1;
            this.huy.Text = "Hủy";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // tim
            // 
            this.tim.AutoSize = true;
            this.tim.Location = new System.Drawing.Point(539, 285);
            this.tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(116, 50);
            this.tim.TabIndex = 2;
            this.tim.Text = "Tìm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // thoat
            // 
            this.thoat.AutoSize = true;
            this.thoat.Location = new System.Drawing.Point(696, 285);
            this.thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(116, 50);
            this.thoat.TabIndex = 3;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(462, 164);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(287, 26);
            this.txtCMND.TabIndex = 5;
            // 
            // HuyVeforHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 378);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HuyVeforHK";
            this.Text = "HuyVeforHK";
            this.Load += new System.EventHandler(this.HuyVeforHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCMND;
    }
}