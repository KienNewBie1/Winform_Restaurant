using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyNhaHang
{
    public partial class Form2test : Form
    {
        public Form2test()
        {
            InitializeComponent();
        }
        static string name;
        private void Form2test_Load(object sender, EventArgs e)
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT DsMon.*
FROM     DsMon";
            cmd.Connection = sqlConnection;
           var r = cmd.ExecuteReader();
            while (r.Read())
            {
                User_MonAn user_MonAn = new User_MonAn();
                user_MonAn.Tenmon = r[0]+"";
                user_MonAn.Gia = r[1]+"";     
                
                // load ảnh từ trên sql về picture box
                Byte[] data = new Byte[0];
                data = (Byte[])(r[2]);
                MemoryStream mem = new MemoryStream(data);
                user_MonAn.img = Image.FromStream(mem);
 
                flowLayoutPanel1.Controls.Add(user_MonAn);
                user_MonAn.buttonclick += new EventHandler(haha);
                
            }    
            sqlConnection.Close();

        }
        private void haha(object sender, EventArgs e)
        {
            User_MonAn user_MonAn = (User_MonAn)sender;
            test.Text = "hoàn thành";
            User_MonAn test_MonAn = new User_MonAn();
            MessageBox.Show(user_MonAn.Tenmon + "");
            
           
        }
    }
}
