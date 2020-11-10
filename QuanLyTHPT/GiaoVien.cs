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

        
    }
}
