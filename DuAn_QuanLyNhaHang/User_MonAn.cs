using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyNhaHang
{
    public partial class User_MonAn : UserControl
    {

        public decimal MaMonAn;

        public User_MonAn()
        {
            InitializeComponent();
        }

        private void User_MonAn_Load(object sender, EventArgs e)
        {

        }
        
        private string _Tenmon;
        private string _Gia;
        private Image _img;
        public string Tenmon
        {
            get { return _Tenmon; }
            set { _Tenmon = value; lb_TenMon.Text = value; }
        }

        public string Gia
        {
            get { return _Gia; }
            set { _Gia = value; lb_Gia.Text = value; }
        }

        public Image img
        {
            get { return _img; }
            set { _img = value; pb_AnhMon.Image = value; }
        }
        public event EventHandler buttonclick;
        private void User_MonAn_Click(object sender, EventArgs e)
        {

            buttonclick(sender, e);

        }
       
       
        private void pb_AnhMon_DoubleClick(object sender, EventArgs e)
        {

        }

        
    }
}
