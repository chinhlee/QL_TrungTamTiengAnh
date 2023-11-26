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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TrungTamTiengAnh
{
    public partial class DoiMatKhau : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_doimk_Click(object sender, EventArgs e)
        {
            //string password = pass.Text;
            //string newPassword = newpass1.Text;
            //string comfimPassword = newpass2.Text;
            if (pass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ");
            }
            else if (newpass1.Text == "")
            {
               MessageBox.Show("Bạn chưa nhập mật khẩu mới");
            }
            else if (newpass2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới");
            }
            else if (newpass1.Text == pass.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!");
            }
            else if (newpass1.Text != newpass2.Text)
                    {
                MessageBox.Show("Mật khẩu mới của bạn không trùng khớp!");
            }
            else
            {  //thực hiện đổi pass
                conn = new SqlConnection(strconn);
                conn.Open();
                //string doi = "select count (*) from TaiKhoan where TaiKhoan='" + TaiKhoan.Text + "' and MatKhau='" + pass.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter("select count (*) from TaiKhoan where TaiKhoan='" + TaiKhoan.Text + "' and MatKhau='" + pass.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (newpass1.Text == newpass2.Text)
                    {
                        string sql = "UPDATE TaiKhoan SET MatKhau= '" + newpass1.Text + "' WHERE TaiKhoan= '" + TaiKhoan.Text + "'";
                        //SqlDataAdapter dal = new SqlDataAdapter(sql, conn);
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //SqlCommand command = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.Text;               
                // cmd.CommandType = cmd.string.Concat("UPDATE taikhoan SET pass=N '"+txt_matkhaumoi.Text+"' WHERE nane=N'"+txttaikhoan.Text+"'");                  
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Thay đổi mật khẩu thành công!");
            }
        }

        private void TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
