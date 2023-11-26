using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TrungTamTiengAnh
{
    public partial class Login : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            taikhoan.Clear();
            matkhau.Clear();
        }

        private void taikhoan_TextChanged(object sender, EventArgs e)
        {
            taikhoan.MaxLength = 30;
        }

        private void matkhau_TextChanged(object sender, EventArgs e)
        {
            matkhau.MaxLength = 15;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                matkhau.PasswordChar = (char)0;
            }
            else
            {
                matkhau.PasswordChar = '*';
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");
            if ((taikhoan.Text == "") || (matkhau.Text == ""))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taikhoan.Focus();
            }
            else if (!hasNumber.IsMatch(matkhau.Text))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một kí tự số! ");
                return;
            }
            else if (!hasUpperChar.IsMatch(matkhau.Text))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một kí tự in hoa! ");
            }
            else if (!hasLowerChar.IsMatch(matkhau.Text))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một kí tự thường! ");
            }
            else if (!hasSymbols.IsMatch(matkhau.Text))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một kí tự đặc biệt! ");
            }
            else if ((taikhoan.Text == "") || (matkhau.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taikhoan.Focus();
            }
            else
            {
                //Main dn = new Main();
                //dn.Show();
                //this.Hide();
                conn = new SqlConnection(strconn);
                SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan where TaiKhoan= '" + taikhoan.Text + "' and MatKhau= '" + matkhau.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Main f = new Main(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString());
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.Show();
            this.Hide();
        }
    }
}
