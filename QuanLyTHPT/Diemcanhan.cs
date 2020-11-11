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
using QuanLyTHPT.Data;
namespace QuanLyTHPT
{
    public partial class Diemcanhan : DevExpress.XtraEditors.XtraUserControl
    {
        public Diemcanhan()
        {
            InitializeComponent();
        }
        DataProvider dataProvider = new DataProvider();
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string querytimkiem = "select * from HocSinh where TenHS like N'%" + txTimkiemHS.Text.ToString() + "%'";
            dtgHS.DataSource = dataProvider.GetDataTable(querytimkiem);
        }
        private void HocSinh_load(object sender, EventArgs e)
        {
            string query = "select *from HocSinh";
            dtgHS.DataSource = dataProvider.GetDataTable(query);
        }
        private void Diemcanhan_Load(object sender, EventArgs e)
        {
            string query = "select *from HocSinh";
            dtgHS.DataSource = dataProvider.GetDataTable(query);
        }
    }
}
