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



       
    }
}
