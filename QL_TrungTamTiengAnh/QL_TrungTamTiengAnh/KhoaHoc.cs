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
    public partial class KhoaHoc : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public KhoaHoc()
        {
            InitializeComponent();
        }

        
        public void Clear_form()
        {
            maKH.Clear();
            tenKH.Clear();
            hocPhi.Clear();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Thêm_khóa_học themkhoahoc = new Thêm_khóa_học();
            themkhoahoc.ShowDialog();
            HienThi_DGV();

        }
        private void KhoaHoc_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }
        public void HienThi_DGV()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_ht = "select*from KhoaHoc";
                da = new SqlDataAdapter(sql_ht, conn);
                dt = new DataTable();
                da.Fill(dt); //đổ DL vào 
                dgv_khoahoc.DataSource = dt;
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
                string sql_search = "select * from KhoaHoc where maKH='" + maKH.Text + "'or TenKH='" + tenKH.Text + "'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dgv_khoahoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (maKH.Text == "")
            {
                MessageBox.Show("Nhập mã khóa học cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maKH.Focus();
            }
            else
            {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_sua = "update KhoaHoc set maKH='" + maKH.Text + "',TenKH='" + tenKH.Text + "',HocPhi='" + hocPhi.Text + "'where maKH='" + maKH.Text + "'";
                cmd = new SqlCommand(sql_sua, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi_DGV();
                Clear_form();
                maKH.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
            }
        }

        private void dgv_khoahoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maKH.Text = dgv_khoahoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenKH.Text = dgv_khoahoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            hocPhi.Text = dgv_khoahoc.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (maKH.Text == "")
            {
                MessageBox.Show("Nhập mã khóa học cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maKH.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_xoa = "DELETE KhoaHoc where maKH='" + maKH.Text + "'";
                    cmd = new SqlCommand(sql_xoa, conn);
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    HienThi_DGV();
                    Clear_form();
                    maKH.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void bt_reset_Click_1(object sender, EventArgs e)
        {
            maKH.Clear();
            tenKH.Clear();
            hocPhi.Clear();
            maKH.Clear();
            tenKH.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
