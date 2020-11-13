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
