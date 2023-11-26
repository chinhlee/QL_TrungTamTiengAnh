using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QL_TrungTamTiengAnh
{
    public partial class DangKyHoc : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public DangKyHoc()
        {
            InitializeComponent();
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                string khoahoc = @"SELECT maKH
                             FROM KhoaHoc";
                cmd = new SqlCommand(khoahoc, conn);
                dr = cmd.ExecuteReader();//thi hành lệnh, trả về đối tượng giao diện
                while (dr.Read())
                {
                    comboBoxMaKH.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }

            {
                conn = new SqlConnection(strconn);
                conn.Open();
                string lophoc = @"SELECT maLH
                             FROM LopHoc";
                cmd = new SqlCommand(lophoc, conn);
                dr = cmd.ExecuteReader();//thi hành lệnh, trả về đối tượng giao diện
                while (dr.Read())
                {
                    comboBoxMaLH.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
        }

        public void Clear_form()
        {
            maDK.Clear();
            HoTen.Clear();
            gioitinh.Clear();
            diachi.Clear();
            email.Clear();
            sdt.Clear();
            TrangThai.Clear();
            TimKiem1.Clear();
            TimKiem2.Clear();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (maDK.Text == "")
            {
                MessageBox.Show("Chưa nhập mã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maDK.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_them = "insert into DangKyHoc (maDK, HoTen,NgaySinh,GioiTinh,DiaChi,Email,SDT, maKH, maLH, NgayDK, TrangThai) " +
                        "values('" + maDK.Text + "','" + HoTen.Text + "','" + ngaysinh.Value.ToShortDateString().ToString() + "','" + gioitinh.Text + "','" +
                        diachi.Text + "','" + email.Text + "','" + sdt.Text + "','"+
                        comboBoxMaKH.Text + "','" + comboBoxMaLH.Text + "','" +
                        NgayDK.Value.ToShortDateString().ToString() + "','" + TrangThai.Text + "')";
                    cmd = new SqlCommand(sql_them, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maDK.Focus();

                }
                catch (SqlException ex)
                {
                    if (maDK.Text.Equals(maDK.Text))
                    {
                        MessageBox.Show("Trùng mã đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }
        public void HienThi_DGV()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_ht = "select*from DangKyHoc";
                SqlDataAdapter da = new SqlDataAdapter(sql_ht, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        private void DangKyHoc_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_search = "select * from DangKyHoc where maDK='" + TimKiem1.Text + "' or TrangThai='" + TimKiem2.Text + "'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (maDK.Text == "")
            {
                MessageBox.Show("Nhập mã đăng ký cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maDK.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_sua = "update DangKyHoc set maDK='" + maDK.Text + "',HoTen='" + HoTen.Text + "',NgaySinh='" + ngaysinh.Value.ToShortDateString().ToString() + "',GioiTinh='" + gioitinh.Text + "',DiaChi='" + diachi.Text + "',Email='" + email.Text + "',SDT='" + sdt.Text + "',maKH='" + comboBoxMaKH.Text + "',maLH='" + comboBoxMaLH.Text + "',NgayDK='" + NgayDK.Value.ToShortDateString().ToString() + "',TrangThai='" + TrangThai.Text + "'where maDK='" + maDK.Text + "'";
                    cmd = new SqlCommand(sql_sua, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maDK.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maDK.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            HoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ngaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            gioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            diachi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            sdt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBoxMaLH.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            NgayDK.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            TrangThai.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (maDK.Text == "")
            {
                MessageBox.Show("Nhập mã đăng ký cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maDK.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_xoa = "DELETE DangKyHoc where maDK='" + maDK.Text + "'";
                    cmd = new SqlCommand(sql_xoa, conn);
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    HienThi_DGV();
                    Clear_form();
                    maDK.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            maDK.Clear();
            HoTen.Clear();
            gioitinh.Clear();
            diachi.Clear();
            email.Clear();
            sdt.Clear();
            TrangThai.Clear();
            TimKiem1.Clear();
            TimKiem2.Clear();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKiem1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            if (ngaysinh.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
            }
        }

        private void NgayDK_ValueChanged(object sender, EventArgs e)
        {
            //if (NgayDK.Value < DateTime.Today)
            //{
               // MessageBox.Show("Ngày đăng kí không hợp lệ!");
            //}
        }

        private void maDK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
