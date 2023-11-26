namespace QL_TrungTamTiengAnh
{
    partial class TaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maTK = new System.Windows.Forms.TextBox();
            this.tenTK = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TimKiem1 = new System.Windows.Forms.TextBox();
            this.TimKiem2 = new System.Windows.Forms.TextBox();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTK = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiTK = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matkhau);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxLoaiTK);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.sdt);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Controls.Add(this.tenTK);
            this.groupBox1.Controls.Add(this.maTK);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loaiTK);
            this.groupBox2.Controls.Add(this.TimKiem2);
            this.groupBox2.Controls.Add(this.TimKiem1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(357, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_taikhoan);
            this.groupBox3.Location = new System.Drawing.Point(719, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 299);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // maTK
            // 
            this.maTK.Location = new System.Drawing.Point(135, 32);
            this.maTK.Name = "maTK";
            this.maTK.Size = new System.Drawing.Size(188, 26);
            this.maTK.TabIndex = 6;
            // 
            // tenTK
            // 
            this.tenTK.Location = new System.Drawing.Point(135, 67);
            this.tenTK.Name = "tenTK";
            this.tenTK.Size = new System.Drawing.Size(188, 26);
            this.tenTK.TabIndex = 8;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(135, 139);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(188, 26);
            this.hoten.TabIndex = 9;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(135, 177);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(188, 26);
            this.sdt.TabIndex = 10;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(135, 215);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(188, 26);
            this.email.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(318, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã tài khoản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Họ và tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Loại tài khoản";
            // 
            // TimKiem1
            // 
            this.TimKiem1.Location = new System.Drawing.Point(135, 32);
            this.TimKiem1.Name = "TimKiem1";
            this.TimKiem1.Size = new System.Drawing.Size(211, 26);
            this.TimKiem1.TabIndex = 3;
            // 
            // TimKiem2
            // 
            this.TimKiem2.Location = new System.Drawing.Point(135, 76);
            this.TimKiem2.Name = "TimKiem2";
            this.TimKiem2.Size = new System.Drawing.Size(211, 26);
            this.TimKiem2.TabIndex = 4;
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_taikhoan.Location = new System.Drawing.Point(0, 26);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.RowHeadersWidth = 62;
            this.dgv_taikhoan.RowTemplate.Height = 28;
            this.dgv_taikhoan.Size = new System.Drawing.Size(560, 273);
            this.dgv_taikhoan.TabIndex = 0;
            this.dgv_taikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellContentClick);
            this.dgv_taikhoan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_RowEnter);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_reset.Location = new System.Drawing.Point(372, 240);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(132, 35);
            this.bt_reset.TabIndex = 4;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_tim.Location = new System.Drawing.Point(560, 240);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(132, 35);
            this.bt_tim.TabIndex = 5;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_them.Location = new System.Drawing.Point(372, 282);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(132, 35);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sua.Location = new System.Drawing.Point(560, 282);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(132, 35);
            this.bt_sua.TabIndex = 7;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Red;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_xoa.Location = new System.Drawing.Point(372, 325);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(132, 35);
            this.bt_xoa.TabIndex = 8;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_thoat.Location = new System.Drawing.Point(560, 325);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(132, 35);
            this.bt_thoat.TabIndex = 9;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maTK";
            this.Column1.HeaderText = "Mã tài khoản";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TaiKhoan";
            this.Column2.HeaderText = "Tài khoản";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LoaiTK";
            this.Column3.HeaderText = "Loại tài khoản";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HoTen";
            this.Column4.HeaderText = "Họ và tên";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Số điện thoại";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // loaiTK
            // 
            this.loaiTK.Location = new System.Drawing.Point(135, 117);
            this.loaiTK.Name = "loaiTK";
            this.loaiTK.Size = new System.Drawing.Size(211, 26);
            this.loaiTK.TabIndex = 5;
            // 
            // comboBoxLoaiTK
            // 
            this.comboBoxLoaiTK.FormattingEnabled = true;
            this.comboBoxLoaiTK.Location = new System.Drawing.Point(135, 101);
            this.comboBoxLoaiTK.Name = "comboBoxLoaiTK";
            this.comboBoxLoaiTK.Size = new System.Drawing.Size(188, 28);
            this.comboBoxLoaiTK.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mật khẩu";
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(135, 253);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(188, 26);
            this.matkhau.TabIndex = 15;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1280, 370);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox tenTK;
        private System.Windows.Forms.TextBox maTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TimKiem2;
        private System.Windows.Forms.TextBox TimKiem1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.ComboBox comboBoxLoaiTK;
        private System.Windows.Forms.TextBox loaiTK;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label label12;
    }
}