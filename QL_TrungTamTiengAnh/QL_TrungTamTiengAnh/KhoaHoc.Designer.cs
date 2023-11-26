namespace QL_TrungTamTiengAnh
{
    partial class KhoaHoc
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
            this.tenKH = new System.Windows.Forms.TextBox();
            this.maKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_khoahoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hocPhi = new System.Windows.Forms.TextBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(221, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÓA HỌC\r\n";
            // 
            // tenKH
            // 
            this.tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKH.Location = new System.Drawing.Point(572, 171);
            this.tenKH.Name = "tenKH";
            this.tenKH.Size = new System.Drawing.Size(251, 30);
            this.tenKH.TabIndex = 3;
            // 
            // maKH
            // 
            this.maKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKH.Location = new System.Drawing.Point(572, 90);
            this.maKH.Name = "maKH";
            this.maKH.Size = new System.Drawing.Size(251, 30);
            this.maKH.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên khóa học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(540, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khóa học";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_khoahoc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 435);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khóa học";
            // 
            // dgv_khoahoc
            // 
            this.dgv_khoahoc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_khoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khoahoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_khoahoc.Location = new System.Drawing.Point(6, 26);
            this.dgv_khoahoc.Name = "dgv_khoahoc";
            this.dgv_khoahoc.RowHeadersWidth = 62;
            this.dgv_khoahoc.RowTemplate.Height = 28;
            this.dgv_khoahoc.Size = new System.Drawing.Size(514, 403);
            this.dgv_khoahoc.TabIndex = 0;
            this.dgv_khoahoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khoahoc_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKH";
            this.Column1.HeaderText = "Mã khóa học";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên khóa học";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HocPhi";
            this.Column3.HeaderText = "Học phí";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_tim.Location = new System.Drawing.Point(716, 312);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(107, 55);
            this.bt_tim.TabIndex = 4;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_them.Location = new System.Drawing.Point(572, 373);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(107, 55);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sua.Location = new System.Drawing.Point(716, 373);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(107, 55);
            this.bt_sua.TabIndex = 6;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_xoa.Location = new System.Drawing.Point(572, 438);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(107, 55);
            this.bt_xoa.TabIndex = 7;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Học phí";
            // 
            // hocPhi
            // 
            this.hocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocPhi.Location = new System.Drawing.Point(572, 251);
            this.hocPhi.Name = "hocPhi";
            this.hocPhi.Size = new System.Drawing.Size(251, 30);
            this.hocPhi.TabIndex = 11;
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_reset.Location = new System.Drawing.Point(572, 312);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(107, 55);
            this.bt_reset.TabIndex = 12;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click_1);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_thoat.Location = new System.Drawing.Point(716, 438);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(107, 55);
            this.bt_thoat.TabIndex = 13;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // KhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.hocPhi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenKH);
            this.Controls.Add(this.maKH);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "KhoaHoc";
            this.Text = "KhoaHoc";
            this.Load += new System.EventHandler(this.KhoaHoc_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenKH;
        private System.Windows.Forms.TextBox maKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_khoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hocPhi;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_thoat;
    }
}