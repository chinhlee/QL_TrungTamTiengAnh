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
    public partial class Main : Form
    {
        string TaiKhoan = "", LoaiTK = "", HoTen = "", SDT = "", Email = "", MatKhau = "";
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public Main()
        {
            InitializeComponent();
            
        }
        public Main(string TaiKhoan, string LoaiTK, string HoTen, string SDT, string Email, string MatKhau)
        {
            InitializeComponent();
            this.TaiKhoan=TaiKhoan;
            this.LoaiTK=LoaiTK;
            this.HoTen=HoTen;
            this.SDT=SDT;
            this.Email=Email;
            this.MatKhau=MatKhau;

        }
        public bool isThoat = true;

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doimatkhau = new DoiMatKhau();
            doimatkhau.Show();
            IsMdiContainer = true;
            doimatkhau.MdiParent = this;

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(sender as Main).isThoat = false;
            //(sender as Main).Close();
            //this.Show();
        }

        private void quảnLýKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoaHoc khoahoc = new KhoaHoc();
            khoahoc.Show();
            IsMdiContainer = true;
            khoahoc.MdiParent = this;
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopHoc lophoc = new LopHoc();
            lophoc.Show();
            IsMdiContainer = true;
            lophoc.MdiParent = this;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.Show();
            IsMdiContainer = true;
            nhanvien.MdiParent = this;
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiangVien giangvien = new GiangVien();
            giangvien.Show();
            IsMdiContainer = true;
            giangvien.MdiParent = this;
        }


        private void quảnLýHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HocVien hocvien = new HocVien();
            hocvien.Show();
            IsMdiContainer = true;
            hocvien.MdiParent = this;
        }

        private void thốngKêLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeLopHoc tklophoc = new ThongKeLopHoc();
            tklophoc.Show();
            IsMdiContainer = true;
            tklophoc.MdiParent = this;
        }

        private void theoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeGiangVien tkgiangvien = new ThongKeGiangVien();
            tkgiangvien.Show();
            IsMdiContainer = true;
            tkgiangvien.MdiParent = this;
        }

        private void theoLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeGV tkgv = new ThongKeGV();
            tkgv.Show();
            IsMdiContainer = true;
            tkgv.MdiParent = this;
        }

        private void theoKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeHocVien tkhocvien = new ThongKeHocVien();
            tkhocvien.Show();
            IsMdiContainer = true;
            tkhocvien.MdiParent = this;
        }

        private void theoLớpHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeHV tkhv = new ThongKeHV();
            tkhv.Show();
            IsMdiContainer = true;
            tkhv.MdiParent = this;
        }

        private void quảnLýĐăngKýHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DangKyHoc dangkyhoc = new DangKyHoc();
            dangkyhoc.Show();
            IsMdiContainer = true;
            dangkyhoc.MdiParent = this;
        }

        private void danhMụcTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.Show();
            IsMdiContainer = true;
            taikhoan.MdiParent = this;
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        //PHÂN QUYỀN
        private void Main_Load(object sender, EventArgs e)
        {
            if(LoaiTK=="Admin")
            {
                thayĐổiMậtKhẩuToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                quảnLýKhóaHọcToolStripMenuItem.Visible = true;
                quảnLýLớpHọcToolStripMenuItem.Visible = true;
                quảnLýNhânViênToolStripMenuItem.Visible = true;
                quảnLýGiảngViênToolStripMenuItem.Visible=true;
                quảnLýHọcViênToolStripMenuItem.Visible= true;
                quảnLýĐăngKýHọcToolStripMenuItem.Visible = true;
                danhMụcTàiKhoảnToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                //thoátToolStripMenuItem = true;
            }
            else
            {
                quảnLýNhânViênToolStripMenuItem.Visible = false;
                danhMụcTàiKhoảnToolStripMenuItem.Visible = false; 
            }
        }
    }
}
