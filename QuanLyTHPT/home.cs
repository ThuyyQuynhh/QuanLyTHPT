using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QuanLyTHPT.Data;
namespace QuanLyTHPT
{
    public partial class home : DevExpress.XtraBars.Ribbon.RibbonForm//giải thích chỗ này
    {
        public string userName;
        public string pass;
        
        public home()
        {
           
            InitializeComponent();
          
            

        }
        // giao diện của sự kiện khi load form lên sẽ mặc định là office 2007 green
        private void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel def = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            def.LookAndFeel.SkinName = "Office 2007 Pink";
        }
        // khi load form gọi tới skin() => để laod giao diện mặc định lên
        private void home_Load(object sender, EventArgs e)
        {
            //TrangChu TC = new TrangChu();
            //addpage(fr_main, "Trang chủ", TC);


            skin();
        }
        /* phương thức thêm 1 page vào xtratabcontrol 
            - xtratabcha: Tên của xtratabcontrol được dùng để thêm các tabpage con
            - tabname: Tên sẽ hiển thị ra của tabpage con
            - usetr: usercontrol được thêm vào cái page mới được tạo ra
         */
        
    }
}