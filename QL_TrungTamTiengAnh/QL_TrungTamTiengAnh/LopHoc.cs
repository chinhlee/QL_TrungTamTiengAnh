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
    public partial class LopHoc : Form

    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public LopHoc()
        {
            InitializeComponent();
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                string giangvien = @"SELECT maGV 
                             FROM GiangVien";
                cmd = new SqlCommand(giangvien, conn);
                dr = cmd.ExecuteReader();//thi hành lệnh, trả về đối tượng giao diện
                while (dr.Read())
                {
                    comboBoxMaGV.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }

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
        }
        public void Clear_form()
        {
            maLH.Clear();
            tenLH.Clear();
            siSo.Clear();
            trinhDo.Clear();
            caHoc.Clear();
            trangThai.Clear();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (maLH.Text == "")
            {
                MessageBox.Show("Chưa nhập mã lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maLH.Focus();
            }
            else 
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_them = "insert into LopHoc (maLH, TenLH, NgayBD, NgayKT, maGV, maKH, SiSo, TrinhDo, CaHoc, TrangThai) " + "values('" + maLH.Text + "','" + tenLH.Text + "','" + ngayBD.Value.ToShortDateString().ToString() + "','" + ngayKT.Value.ToShortDateString().ToString() + "','" + comboBoxMaGV.Text + "','" + comboBoxMaKH.Text + "','" + siSo.Text + "','" + trinhDo.Text + "','" + caHoc.Text + "','" + trangThai.Text + "')";
                    cmd = new SqlCommand(sql_them, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maLH.Focus();
                    //thực hiện các thao tác thêm DL
                }
                catch (SqlException ex)
                {
                    if (maLH.Text.Equals(maLH.Text))
                    {
                        MessageBox.Show("Trùng mã lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sql_ht = "select*from LopHoc";
                SqlDataAdapter da = new SqlDataAdapter(sql_ht, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_lophoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_search = "select * from LopHoc where maLH='" + TimKiem1.Text + "' or maKH='" + TimKiem2.Text  + "' or maGV='" + TimKiem3.Text + "'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dgv_lophoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }


        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (maLH.Text == "")
            {
                MessageBox.Show("Nhập mã lớp học cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maLH.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_sua = "update LopHoc set maLH='" + maLH.Text + "',TenLH='" + tenLH.Text + "',NgayBD='" + ngayBD.Value.ToShortDateString().ToString() + "',NgayKT='" + ngayKT.Value.ToShortDateString().ToString() + "',maGV='" + comboBoxMaGV.Text + "',maKH='" + comboBoxMaKH.Text + "',SiSo='" + siSo.Text + "',TrinhDo='" + trinhDo.Text + "',CaHoc='" + caHoc.Text + "',TrangThai='" + trangThai.Text + "'where maLH='" + maLH.Text + "'";
                    cmd = new SqlCommand(sql_sua, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi_DGV();
                    Clear_form();
                    maLH.Focus();
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
            if (maLH.Text == "")
            {
                MessageBox.Show("Nhập mã lớp học cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maLH.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_xoa = "DELETE LopHoc where maLH='" + maLH.Text + "'";
                    cmd = new SqlCommand(sql_xoa, conn);
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    HienThi_DGV();
                    Clear_form();
                    maLH.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        

        private void dgv_lophoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maLH.Text = dgv_lophoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenLH.Text = dgv_lophoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            ngayBD.Text = dgv_lophoc.Rows[e.RowIndex].Cells[2].Value.ToString();
            ngayKT.Text = dgv_lophoc.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxMaGV.Text = dgv_lophoc.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxMaKH.Text = dgv_lophoc.Rows[e.RowIndex].Cells[5].Value.ToString();
            siSo.Text = dgv_lophoc.Rows[e.RowIndex].Cells[6].Value.ToString();
            trinhDo.Text = dgv_lophoc.Rows[e.RowIndex].Cells[7].Value.ToString();
            caHoc.Text = dgv_lophoc.Rows[e.RowIndex].Cells[8].Value.ToString();
            trangThai.Text = dgv_lophoc.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void ngayBD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void siSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            maLH.Clear();
            tenLH.Clear();
            siSo.Clear();
            trinhDo.Clear();
            caHoc.Clear();
            trangThai.Clear();
            TimKiem1.Clear();
            TimKiem2.Clear();
            TimKiem3.Clear();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKiem2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
