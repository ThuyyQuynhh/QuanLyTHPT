using QuanLyTHPT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTHPT.Data;

namespace QuanLyTHPT
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();

        }
        DataProvider dataProvider = new DataProvider();


        private void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel def = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            def.LookAndFeel.SkinName = "Office 2007 Pink";
        }
        // Kiểm tra tài khoản mật khẩu đăng nhập có chính xác hay không
        private bool dangNhap()
        {
            string query = "SELECT * from admin where Taikhoan = '" + taikhoan.Text + "' and Password = '" + matkhau.Text + "'";
            // lấy data từ database 
            DataTable result = dataProvider.GetDataTable(query);
            // nếu có trường dữ liệu trùng với tài khoản và mật khẩu thì datatable sẽ có dữ liệu => row > 0
            return result.Rows.Count > 0;
        }





        // button thoát form đăng nhập = > thoát chương trình
        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // sự kiện khi click vào checkbox hiện mật khẩu
        private void showmk_CheckedChanged(object sender, EventArgs e)
        {
            // nếu chọn hiện mật khẩu => cấu hình lại thuộc tính password
            if (showmk.Checked)
            {
                matkhau.PasswordChar = (Char)0;//hiển thị lại mật khẩu nhập
            }
            // bỏ chọn chức năng hiện mật khẩu = > cấu hình lại thuộc tính password
            else
            {

                matkhau.PasswordChar = '*';//hiện thị mật khẩu bằng dấu *
            }


        }
        // Sự kiện click button đăng nhập
        private void BTN_DangNhap_Click(object sender, EventArgs e)
        {
            if (taikhoan.Text == "" || matkhau.Text == "")
            {
                MessageBox.Show("Nhập tài khoản mật khẩu ");
            }

            //else
            //{

            //    if (dangNhap())
            //    {
            //        home TC = new home();
            //        this.Hide();
            //        TC.ShowDialog();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài khoản đăng nhập không đúng !!!");
            //    }
            //}

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            skin();
        }


    }
}
