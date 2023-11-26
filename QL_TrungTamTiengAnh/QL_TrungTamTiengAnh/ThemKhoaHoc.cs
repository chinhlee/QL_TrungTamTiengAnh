using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TrungTamTiengAnh
{
    public partial class Thêm_khóa_học : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        public Thêm_khóa_học()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (maKH.Text == "")
            {
                MessageBox.Show("Chưa nhập mã khóa học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maKH.Focus();
            }
            else
            {
                conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    string sql_them = "insert into KhoaHoc (maKH, TenKH, HocPhi) " +
                        "values('" + maKH.Text + "','" + tenKH.Text + "','" + hocPhi.Text + "')";
                    cmd = new SqlCommand(sql_them, conn);
                    DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm khóa học không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    maKH.Focus();
                    //thực hiện các thao tác thêm DL
                }
                catch (SqlException ex)
                {
                    if (maKH.Text.Equals(maKH.Text))
                    {
                        MessageBox.Show("Trùng mã khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                conn.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
