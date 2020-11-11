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
    public partial class GiaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        public GiaoVien()
        {
            InitializeComponent();
        }
        DataProvider dataProvider = new DataProvider();
        private void dtgDSGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GiaoVien_Load_1(object sender, EventArgs e)
        {
            
            string querydata = "select * from GiaoVien ";

            
            dtgDSGiaoVien.DataSource = dataProvider.GetDataTable(querydata);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string querytimkiem = "select * from GiaoVien where TenGV like N'%" + txKhoaGV.Text.ToString() + "%'";
            dtgDSGiaoVien.DataSource = dataProvider.GetDataTable(querytimkiem);
        }

        private void dtgDSGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgDSGiaoVien.CurrentRow.Index;
            btnSua.Enabled = true;
            btnLamMoi.Enabled = true;
            
            txMaGV.Text = dtgDSGiaoVien.Rows[i].Cells[0].Value.ToString();
            txTenGV.Text = dtgDSGiaoVien.Rows[i].Cells[1].Value.ToString();
            if(dtgDSGiaoVien.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
                rdbNam.Enabled = true;
                rdbNu.Enabled = true;
            }
            if (dtgDSGiaoVien.Rows[i].Cells[2].Value.ToString() == "Nữ")
            {
                rdbNu.Checked = true;
                rdbNam.Checked = false;
                rdbNam.Enabled = true;
                rdbNu.Enabled = true;
            }
            dtpGV.Text = dtgDSGiaoVien.Rows[i].Cells[3].Value.ToString();
            txDiaChi.Text = dtgDSGiaoVien.Rows[i].Cells[4].Value.ToString();
            txSDT.Text = dtgDSGiaoVien.Rows[i].Cells[5].Value.ToString();
        }

       
    }
}
