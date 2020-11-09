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
    public partial class QuanLyDiem : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }
        DataProvider dataProvider = new DataProvider();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Khoi_Load (object sender, EventArgs e)
        {
           
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            txlop.Text = cmblop.Text;
            string query = "select HS.MaHS, HS.TenHS,HS.GioiTinh,HS.NgaySinh, HS.DiaChi from HocSinh HS, Lop L where HS.MaLop = L.MaLop and L.TenLop = '" + cmblop.Text + "'";
            DataTable datagan = dataProvider.GetDataTable(query);
            dgvDiemLop.ColumnCount = 6;
            dgvDiemLop.RowCount = datagan.Rows.Count;
            for (int i =0 ; i <= datagan.Rows.Count-1; i++)
            {
                for(int j=0;j<=4;j++)
                {
                    string x = datagan.Rows[i][j].ToString();
                    dgvDiemLop.Rows[i].Cells[j].Value = x;
                }
                string queryDTB = "exec DTB '" + dgvDiemLop.Rows[i].Cells[0].Value.ToString() + "'";
                DataTable data = dataProvider.GetDataTable(queryDTB);
                string y = data.Rows[0][1].ToString();
                dgvDiemLop.Rows[i].Cells[5].Value = y;
            }
            
            string query1 = "select GV.TenGV from Lop L, GiaoVien GV where L.MaGVCN = GV.MaGV and L.TenLop='" + cmblop.Text + "'";
            DataTable data1 = dataProvider.GetDataTable(query1);
            txGvcn.Text = data1.Rows[0][0].ToString();
            
            
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            string queryk = "SELECT * FROM Khoi";
            cmbKhoi.DataSource = dataProvider.GetDataTable(queryk);
            // hiển thị ra tên các danh mục
            cmbKhoi.DisplayMember = "TenKhoi";
            // giá trị của mỗi tên danh mục sẽ được đại diện bằng value của danh mục đó là MaDm
            cmbKhoi.ValueMember = "MaKhoi";
            ////////////////////////////////////////

            
        }

        private void cmbKhoi_DisplayMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbKhoi_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbKhoi_SelectedValueChanged(object sender, EventArgs e)
        {
            string queryl = "select L.Malop, L.TenLop from Khoi K, Lop L where K.MaKhoi = L.MaKhoi and K.TenKhoi = N'" + cmbKhoi.Text + "'";
            cmblop.DataSource = dataProvider.GetDataTable(queryl);
            // hiển thị ra tên các danh mục
            cmblop.DisplayMember = "TenLop";
            // giá trị của mỗi tên danh mục sẽ được đại diện bằng value của danh mục đó là MaDm
            cmblop.ValueMember = "MaLop";
        }
    }
}
