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

        private void btnXoa_Click(object sender, EventArgs e)
        {
                int i = dtgDSGiaoVien.CurrentRow.Index;
                dtgDSGiaoVien.DataSource = dataProvider.GetDataTable("delete from GiaoVien where MaGV = '" + dtgDSGiaoVien.Rows[i].Cells[0].Value.ToString() + "' select * from GiaoVien");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txMaGV.Text == ""||txTenGV.Text == ""||dtpGV.Text == ""||txDiaChi.Text == ""||txSDT.Text == "")
            {
                MessageBox.Show("Điền đủ thông tin trước khi chọn sửa");
            }
            else
            {
                
                string querynam = "update GiaoVien set TenGV =N'" + txTenGV.Text + "', GioiTinh =N'" + rdbNam.Text + "',NgaySinh = '" + dtpGV.Value.ToString("yyyy-MM-dd") + "',DiaChi = N'" + txDiaChi.Text + "', SDT= '" + txSDT.Text  + "' where MaGV= '" + txMaGV.Text + "'";
                string querynu = "update GiaoVien set TenGV =N'" + txTenGV.Text + "', GioiTinh =N'" + rdbNu.Text + "',NgaySinh = '" + dtpGV.Value.ToString("yyyy-MM-dd") + "',DiaChi = N'" + txDiaChi.Text + "', SDT= '" + txSDT.Text + "' where MaGV= '" + txMaGV.Text + "'";
                if(rdbNam.Checked == true)
                {
                   
                    dataProvider.exc(querynam);
                }
                else
                {
                    //SqlCommand cmd = new SqlCommand(querynu, connect);
                    dataProvider.exc(querynu);
                }                    
               // connect.Close();
                dtgDSGiaoVien.DataSource = dataProvider.GetDataTable("select * from GiaoVien");

            }
        }

        
    }
}
