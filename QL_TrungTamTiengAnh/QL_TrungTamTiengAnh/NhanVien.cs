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
    public partial class NhanVien : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public NhanVien()
        {
            InitializeComponent();
        }
        public void Clear_form()
        {
            maNV.Clear();
            hoten.Clear();
            gioitinh.Clear();
            dienthoai.Clear();
            email.Clear();
            diachi.Clear();
            taikhoan.Clear();
        }

        private void timkiem1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            maNV.Clear();
            hoten.Clear();
            gioitinh.Clear();
            dienthoai.Clear();
            email.Clear();
            diachi.Clear();
            taikhoan.Clear();
            timkiem1.Clear();
            timkiem2.Clear();
        }
        public void HienThi_DGV()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_ht = "select*from NhanVien";
                da = new SqlDataAdapter(sql_ht, conn);
                dt = new DataTable();
                da.Fill(dt); //đổ DL vào 
                dgv_nhanvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (maNV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maNV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_them = "insert into NhanVien (maNV, hoten,gioitinh,ngaysinh,sdt,email,diachi,TaiKhoan) " +
                        "values('" + maNV.Text + "','" + hoten.Text + "','" +
                        gioitinh.Text + "','" + ngaysinh.Value.ToShortDateString().ToString() + "','" +
                        dienthoai.Text + "','" + email.Text + "','" +
                        diachi.Text + "','" + taikhoan.Text + "')";
                    cmd = new SqlCommand(sql_them, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maNV.Focus();

                }
                catch (Exception ex)
                {
                    if (maNV.Text.Equals(maNV.Text))
                    {
                        MessageBox.Show("Trùng mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (maNV.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maNV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_sua = "update NhanVien set maNV='" + maNV.Text + "',hoten='" + hoten.Text + "',gioitinh='" + gioitinh.Text + "',ngaysinh='" + ngaysinh.Value.ToShortDateString().ToString() + "',sdt='" + dienthoai.Text + "',email='" + email.Text + "',diachi='" + diachi.Text + "',TaiKhoan='" + taikhoan.Text + "'where maNV='" + maNV.Text + "'";
                    cmd = new SqlCommand(sql_sua, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maNV.Focus();
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
                string sql_search = "select * from NhanVien where maNV='" + timkiem1.Text + "' or hoten='" + timkiem2.Text + "'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dgv_nhanvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (maNV.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maNV.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_xoa = "DELETE NhanVien where maNV='" + maNV.Text + "'";
                    cmd = new SqlCommand(sql_xoa, conn);
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    HienThi_DGV();
                    Clear_form();
                    maNV.Focus();
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

        private void dgv_nhanvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maNV.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            hoten.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            gioitinh.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            ngaysinh.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            dienthoai.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            email.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
            diachi.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
            taikhoan.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            if (ngaysinh.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
            }
        }
    }
}
