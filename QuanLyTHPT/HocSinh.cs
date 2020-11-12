using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.SqlClient;
using QuanLyTHPT.Data;
namespace QuanLyTHPT
{
    public partial class HocSinh : DevExpress.XtraEditors.XtraUserControl
    {
        public HocSinh()
        {
            InitializeComponent();
        }
        DataProvider dataProvider = new DataProvider();
        private void dtgDSGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string querytimkiem = "select * from GiaoVien where TenGV like N'%" + txKhoaHS.Text.ToString() + "%'";
            dtgDSHocsinh.DataSource = dataProvider.GetDataTable(querytimkiem);
        }



        private void HocSinh_Load_1(object sender, EventArgs e)
        {
            // load data lên bảng sản phẩm
            string querydata = "select * from HocSinh ";

            // laod lại data lên bảng tìm kiếm
            dtgDSHocsinh.DataSource = dataProvider.GetDataTable(querydata);
        }

        private void dtgDSHocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgDSHocsinh.CurrentRow.Index;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLamMoi.Enabled = true;
            txMaHS.Text = dtgDSHocsinh.Rows[i].Cells[0].Value.ToString();
            txTenHS.Text = dtgDSHocsinh.Rows[i].Cells[1].Value.ToString();
            if (dtgDSHocsinh.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
                rdbNam.Enabled = true;
                rdbNu.Enabled = true;
            }
            if (dtgDSHocsinh.Rows[i].Cells[2].Value.ToString() == "Nữ")
            {
                rdbNu.Checked = true;
                rdbNam.Checked = false;
                rdbNam.Enabled = true;
                rdbNu.Enabled = true;
            }
            dtpHS.Text = dtgDSHocsinh.Rows[i].Cells[3].Value.ToString();
            txDiaChi.Text = dtgDSHocsinh.Rows[i].Cells[4].Value.ToString();
            txMaLop.Text = dtgDSHocsinh.Rows[i].Cells[5].Value.ToString();
        }

    }
}
