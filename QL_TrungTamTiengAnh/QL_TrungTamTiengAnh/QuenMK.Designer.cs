namespace QL_TrungTamTiengAnh
{
    partial class QuenMK
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
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.bt_nhan = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập SDT hoặc Email";
            // 
            // txt_nhap
            // 
            this.txt_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhap.Location = new System.Drawing.Point(237, 274);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(275, 35);
            this.txt_nhap.TabIndex = 2;
            // 
            // bt_nhan
            // 
            this.bt_nhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_nhan.Location = new System.Drawing.Point(49, 333);
            this.bt_nhan.Name = "bt_nhan";
            this.bt_nhan.Size = new System.Drawing.Size(185, 49);
            this.bt_nhan.TabIndex = 3;
            this.bt_nhan.Text = "Nhận lại mật khẩu";
            this.bt_nhan.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_thoat.Location = new System.Drawing.Point(294, 333);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(185, 49);
            this.bt_thoat.TabIndex = 4;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(536, 405);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_nhan);
            this.Controls.Add(this.txt_nhap);
            this.Controls.Add(this.label1);
            this.Name = "QuenMK";
            this.Text = "QuenMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.Button bt_nhan;
        private System.Windows.Forms.Button bt_thoat;
    }
}