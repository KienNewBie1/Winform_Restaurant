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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2test form2Test = new Form2test();
           
            form2Test.Show();

        }

        private void addUserThongKe()
        {
            
            UserC_ThongKe userC_ThongKe = new UserC_ThongKe();
            panel_HienThi.Controls.Add(userC_ThongKe);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            addUserThongKe();
           
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            addUserThongKe();
        }

        private void btn_MonAn_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UserQuanLyMonAn userQuanLyMonAn = new UserQuanLyMonAn();
            panel_HienThi.Controls.Add(userQuanLyMonAn);
        }

        private void btn_ThongKe_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_ThongKe_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.Show();
        }
    }
}
