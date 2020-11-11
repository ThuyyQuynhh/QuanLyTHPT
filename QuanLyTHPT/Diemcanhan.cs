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
        private void dtgHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgHS.CurrentRow.Index;
            txHoten.Text = dtgHS.Rows[i].Cells[1].Value.ToString();
            string queryTenLop = "select L.TenLop from HocSinh HS, Lop L where HS.MaLop = L.MaLop and L.MaLop = '" + dtgHS.Rows[i].Cells[5].Value.ToString() + "'";
            DataTable dataTenLop = dataProvider.GetDataTable(queryTenLop);
            txLop.Text = dataTenLop.Rows[0][0].ToString();
            string query = "select M.TenMon, D.Diem from MonHoc M, Diem D where M.MaMon = D.MaMon and D.MaHS = '" + dtgHS.Rows[i].Cells[0].Value.ToString() + "'";
            DataTable data = dataProvider.GetDataTable(query);
            txToan.Text = data.Rows[0][1].ToString();
            txTin.Text = data.Rows[1][1].ToString();
            txly.Text = data.Rows[2][1].ToString();
            txHoa.Text = data.Rows[3][1].ToString();
            txSinh.Text = data.Rows[4][1].ToString();
            txVan.Text = data.Rows[5][1].ToString();

        }
        
    }
}
