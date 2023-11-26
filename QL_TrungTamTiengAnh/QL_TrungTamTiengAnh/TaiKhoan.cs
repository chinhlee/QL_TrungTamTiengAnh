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
    public partial class TaiKhoan : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public TaiKhoan()
        {
            InitializeComponent();
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                string taikhoan = @"SELECT loaiTK 
                             FROM LoaiTK";
                cmd = new SqlCommand(taikhoan, conn);
                dr = cmd.ExecuteReader();//thi hành lệnh, trả về đối tượng giao diện
                while (dr.Read())
                {
                    comboBoxLoaiTK.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
        }
        public void Clear_form()
        {
            maTK.Clear();
            tenTK.Clear();
            hoten.Clear();
            sdt.Clear();
            email.Clear();
            matkhau.Clear();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            maTK.Clear();
            tenTK.Clear();
            hoten.Clear();
            sdt.Clear();
            email.Clear();
            matkhau.Clear();
            TimKiem1.Clear();
            TimKiem2.Clear();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }
        public void HienThi_DGV()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_ht = "select*from TaiKhoan";
                SqlDataAdapter da = new SqlDataAdapter(sql_ht, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_taikhoan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_search = "select * from TaiKhoan where maTK='" + TimKiem1.Text + "' or HoTen='" + TimKiem2.Text + "' or LoaiTK='" + loaiTK.Text + "'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dgv_taikhoan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (maTK.Text == "")
            {
                MessageBox.Show("Chưa nhập mã tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maTK.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_them = "insert into TaiKhoan (maTK,TaiKhoan,LoaiTK,HoTen,SDT,Email,MatKhau) " +
                        "values('" + maTK.Text + "','" + tenTK.Text + "','" + comboBoxLoaiTK.Text + "','" + hoten.Text + "','" +
                        sdt.Text + "','" + email.Text + "','" + matkhau.Text + "')";
                    cmd = new SqlCommand(sql_them, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maTK.Focus();

                }
                catch (SqlException ex)
                {
                    if (maTK.Text.Equals(maTK.Text))
                    {
                        MessageBox.Show("Trùng mã tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (maTK.Text == "")
            {
                MessageBox.Show("Nhập mã tài khoản cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maTK.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_sua = "update TaiKhoan set maTK='" + maTK.Text + "',TaiKhoan='" + tenTK.Text + "',LoaiTK='" + comboBoxLoaiTK.Text + "',HoTen='" + hoten.Text + "',SDT='" + sdt.Text + "',Email='" + email.Text + "',MatKhau='" + matkhau.Text + "'where maTK='" + maTK.Text + "'";
                    cmd = new SqlCommand(sql_sua, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maTK.Focus();
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
            if (maTK.Text == "")
            {
                MessageBox.Show("Nhập mã tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maTK.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_xoa = "DELETE TaiKhoan where maTK='" + maTK.Text + "'";
                    cmd = new SqlCommand(sql_xoa, conn);
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    HienThi_DGV();
                    Clear_form();
                    maTK.Focus();
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

        private void dgv_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_taikhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maTK.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenTK.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxLoaiTK.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
            hoten.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
            sdt.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[4].Value.ToString();
            email.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[5].Value.ToString();
            matkhau.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
