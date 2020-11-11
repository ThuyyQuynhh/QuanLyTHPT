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

        
        private void btnSua_Click_1(object sender, EventArgs e)
        {

            if (txMaHS.Text == "" || txTenHS.Text == "" || dtpHS.Text == "" || txDiaChi.Text == "" || txMaLop.Text == "")
            {
                MessageBox.Show("Điền đủ thông tin trước khi chọn sửa");
            }
            else
            {
                
                string querynam = "update HocSinh set TenHS =N'" + txTenHS.Text + "', GioiTinh =N'" + rdbNam.Text + "',NgaySinh = '" + dtpHS.Value.ToString("yyyy-MM-dd") + "',DiaChi = N'" + txDiaChi.Text + "', MaLop= '" + txMaLop + "' where MaHS= '" + txMaHS.Text + "'";
                string querynu = "update HocSinh set TenHS =N'" + txTenHS.Text + "', GioiTinh =N'" + rdbNu.Text + "',NgaySinh = '" + dtpHS.Value.ToString("yyyy-MM-dd") + "',DiaChi = N'" + txDiaChi.Text + "', MaLop= '" + txMaLop + "' where MaHS= '" + txMaHS.Text + "'";
                if (rdbNam.Checked == true)
                {
                    //SqlCommand cmd = new SqlCommand(querynam, connect); cmd.ExecuteNonQuery();
                    dataProvider.exc(querynam);
                }
                else
                {
                    //SqlCommand cmd = new SqlCommand(querynu, connect);
                    dataProvider.exc(querynu);
                }
                //connect.Close();
                dtgDSHocsinh.DataSource = dataProvider.GetDataTable("select * from HocSinh");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int i = dtgDSHocsinh.CurrentRow.Index;
            dtgDSHocsinh.DataSource = dataProvider.GetDataTable("delete from HocSinh where MaHS = '" + dtgDSHocsinh.Rows[i].Cells[0].Value.ToString() + "' select * from HocSinh");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txMaHS.Text = "";
            txTenHS.Text = "";
            txKhoaHS.Text = "";
            txDiaChi.Text = "";
            txMaLop.Text = "";
            dtpHS.Text = "";
            rdbNam.Checked = true;
            rdbNu.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txMaHS.Text == "" || txTenHS.Text == "" || dtpHS.Text == "" || txDiaChi.Text == "" || txMaLop.Text == "")
            {
                MessageBox.Show("Điền đủ thông tin trước khi chọn sửa");
            }
            else
            {
                string querynam = "insert into HocSinh values( " + txMaHS.Text + ",N'" + txTenHS.Text + "', GioiTinh =N'" + rdbNam.Text + "',NgaySinh = '" + dtpHS.Value.ToString("yyyy-MM-dd") + "',DiaChi = N'" + txDiaChi.Text + "', MaLop= '" + txMaLop.Text + "') ";
                string querynu = "insert into GiaoVien values( " + txMaHS.Text + ",N'" + txTenHS.Text + "', GioiTinh =N'" + rdbNu.Text + "',NgaySinh = '" + dtpHS.Value.ToString("yyyy-MM-dd") + "',DiaChi = N'" + txDiaChi.Text + "', MaLop= '" + txMaLop.Text + "')";
                if (rdbNam.Checked == true)
                {
                    // SqlCommand cmd = new SqlCommand(querynam, connect); cmd.ExecuteNonQuery();
                    dataProvider.exc(querynam);
                }
                else
                {
                    //SqlCommand cmd = new SqlCommand(querynu, connect);
                    dataProvider.exc(querynu);
                }
                // connect.Close();
                dtgDSHocsinh.DataSource = dataProvider.GetDataTable("select * from GiaoVien");
            }                
        }
    }
}
