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

namespace QL_TrungTamTiengAnh
{
    public partial class GiangVien : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public GiangVien()
        {
            InitializeComponent();
        }

        public void Clear_form()
        {
            maGV.Clear();
            hoten.Clear();
            gioitinh.Clear();
            diachi.Clear();
            email.Clear();
            sdt.Clear();
            trinhdo.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (maGV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maGV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_them = "insert into GiangVien (maGV,HoTen,NgaySinh,GioiTinh,DiaChi,Email,SDT,TrinhDo) " +
                        "values('" + maGV.Text + "','" + hoten.Text + "','" +
                        ngaysinh.Value.ToShortDateString().ToString() + "','" + gioitinh.Text + "','" +
                        diachi.Text + "','" + email.Text + "','" + sdt.Text + "','" + trinhdo.Text +"')";
                    cmd = new SqlCommand(sql_them, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maGV.Focus();

                }
                catch (SqlException ex)
                {
                    if (maGV.Text.Equals(maGV.Text))
                    {
                        MessageBox.Show("Trùng mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sql_ht = "select*from GiangVien";
                SqlDataAdapter da = new SqlDataAdapter(sql_ht, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_giangvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }



        private void bt_tim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_search = "select * from GiangVien where maGV='" + TimKiem1.Text + "' or HoTen='" + TimKiem2.Text+"'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dgv_giangvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (maGV.Text == "")
            {
                MessageBox.Show("Nhập mã giảng viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maGV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_sua = "update GiangVien set maGV='" + maGV.Text + "',HoTen='" + hoten.Text + "',NgaySinh='" + ngaysinh.Value.ToShortDateString().ToString() + "',GioiTinh='" + gioitinh.Text + "',DiaChi='" + diachi.Text + "',Email='" + email.Text + "',SDT='" + sdt.Text + "',TrinhDo='" + trinhdo.Text + "'where maGV='" + maGV.Text + "'";
                    cmd = new SqlCommand(sql_sua, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maGV.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (maGV.Text == "")
            {
                MessageBox.Show("Nhập mã giảng viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maGV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_xoa = "DELETE GiangVien where maGV='" + maGV.Text + "'";
                    cmd = new SqlCommand(sql_xoa, conn);
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    HienThi_DGV();
                    Clear_form();
                    maGV.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_giangvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maGV.Text = dgv_giangvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            hoten.Text = dgv_giangvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            ngaysinh.Text = dgv_giangvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            gioitinh.Text = dgv_giangvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            diachi.Text = dgv_giangvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            email.Text = dgv_giangvien.Rows[e.RowIndex].Cells[5].Value.ToString();
            sdt.Text = dgv_giangvien.Rows[e.RowIndex].Cells[6].Value.ToString();
            trinhdo.Text = dgv_giangvien.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            if (ngaysinh.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
            }
        }


        private void bt_reset_Click(object sender, EventArgs e)
        {
            maGV.Clear();
            hoten.Clear();
            gioitinh.Clear();
            diachi.Clear();
            email.Clear();
            sdt.Clear();
            trinhdo.Clear();
            TimKiem1.Clear();
            TimKiem2.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
