﻿using System;
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
    public partial class ThongKeLopHoc : Form
    {
        string strconn = @"Data Source=DESKTOP-FLRUO8O\SQL2019;Initial Catalog=QL_TrungTamTA;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ThongKeLopHoc()
        {
            InitializeComponent();
        }
        public void Clear_form()
        {
            thang.Clear();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql_search = "select * from LopHoc where month(NgayBD)='" + thang.Text + "'";
                da = new SqlDataAdapter(sql_search, conn);
                dt = new DataTable();
                da.Fill(dt);//Phương thức Fill: đổ dữ liệu từ nguồn dữ liệu vào DataSet
                dgv_thongkelop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
