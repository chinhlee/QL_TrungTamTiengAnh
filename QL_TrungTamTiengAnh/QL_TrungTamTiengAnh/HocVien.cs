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
    public partial class HocVien : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public HocVien()
        {
            InitializeComponent();
            conn = new SqlConnection(strconn);
            conn.Open();
            string lop = @"SELECT maLH 
                             FROM LopHoc";
            cmd = new SqlCommand(lop, conn);
            dr = cmd.ExecuteReader();//thi hành lệnh, trả về đối tượng giao diện
            while (dr.Read())
            {
                comboBoxLopHoc.Items.Add(dr[0].ToString());
            }
            conn.Close();
        }

        public void Clear_form()
        {
            maHV.Clear();
            hoten.Clear();
            gioitinh.Clear();
            diachi.Clear();
            email.Clear();
            sdt.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (maHV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maHV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_them = "insert into HocVien (maHV,HoTen,NgaySinh,GioiTinh,DiaChi,Email,SDT,maLH) " +
                        "values('" + maHV.Text + "','" + hoten.Text + "','" +
                        ngaysinh.Value.ToShortDateString().ToString() + "','" + gioitinh.Text + "','" +
                        diachi.Text + "','" + email.Text + "','" + sdt.Text + "','" + comboBoxLopHoc.Text + "')";
                    cmd = new SqlCommand(sql_them, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maHV.Focus();

                }
                catch (SqlException ex)
                {
                    if (maHV.Text.Equals(maHV.Text))
                    {
                        MessageBox.Show("Trùng mã học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sql_ht = "select*from HocVien";
                SqlDataAdapter da = new SqlDataAdapter(sql_ht, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_hocvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void HocVien_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (maHV.Text == "")
            {
                MessageBox.Show("Nhập mã học viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maHV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_sua = "update HocVien set maHV='" + maHV.Text + "',HoTen='" + hoten.Text + "',NgaySinh='" + ngaysinh.Value.ToShortDateString().ToString() + "',GioiTinh='" + gioitinh.Text + "',DiaChi='" + diachi.Text + "',Email='" + email.Text + "',SDT='" + sdt.Text + "',maLH='" + comboBoxLopHoc.Text + "'where maHV='" + maHV.Text + "'";
                    cmd = new SqlCommand(sql_sua, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maHV.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_search = "select * from HocVien where maHV='" + TimKiem1.Text + "' or HoTen='" + TimKiem2.Text + "' or maLH='" + TimKiem3.Text + "'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dgv_hocvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (maHV.Text == "")
            {
                MessageBox.Show("Nhập mã học viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maHV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_xoa = "DELETE HocVien where maHV='" + maHV.Text + "'";
                    cmd = new SqlCommand(sql_xoa, conn);
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    HienThi_DGV();
                    Clear_form();
                    maHV.Focus();
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

        private void dgv_hocvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maHV.Text = dgv_hocvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            hoten.Text = dgv_hocvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            ngaysinh.Text = dgv_hocvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            gioitinh.Text = dgv_hocvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            diachi.Text = dgv_hocvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            email.Text = dgv_hocvien.Rows[e.RowIndex].Cells[5].Value.ToString();
            sdt.Text = dgv_hocvien.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxLopHoc.Text = dgv_hocvien.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            if (ngaysinh.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            maHV.Clear();
            hoten.Clear();
            gioitinh.Clear();
            diachi.Clear();
            email.Clear();
            sdt.Clear();
            TimKiem1.Clear();
            TimKiem2.Clear();
            TimKiem3.Clear();
        }
    }
}
