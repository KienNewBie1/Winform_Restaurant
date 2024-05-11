using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DuAn_QuanLyNhaHang
{
    public partial class Ban : Form
    {
        private Form_TrangChu f1;
        public Ban(Form_TrangChu f2)
        {
            InitializeComponent();
            this.f1 = f2;
        }

        private void Ban_Load(object sender, EventArgs e)
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM     Ban ";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                Button button = new Button();
                button.Text = r[0].ToString();

                if (r[2].ToString() == "Đã chọn")
                {
                    button.BackColor = Color.Red;
                } 
                else
                {
                    button.BackColor = Color.Green;
                }
                button.Height = 100;
                button.Width = 200;
                button.Click += new EventHandler(test);
                fl_DS_Ban.Controls.Add(button);
            }
            sqlConnection.Close();
            

        }
        private string tancuaban;
        public string tenban
        {
            get
            {
                return tancuaban;
            }
        }
        private void test(object sender, EventArgs e)
        {
            Button newbtn = (Button)sender;
            if(newbtn.BackColor.ToString() == "Color [Red]")
            {
                //newbtn.BackColor = Color.Red;


                //string tenban = newbtn.Text;
                //String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(link);
                //sqlConnection.Open();
                //SqlCommand newcd = new SqlCommand();
                //newcd.Connection = sqlConnection;
                //newcd.CommandText = "UPDATE Ban SET Trangthai = N'Đã chọn' WHERE TenBan like  N'%" + tenban + "%'";
                //newcd.ExecuteNonQuery();
                //sqlConnection.Close();
                string tenban = newbtn.Text;
                f1.lb_ChonBan.Text = tenban;
                f1.loaddata();
                this.Hide();

            }    
            else
            {
                //newbtn.BackColor = Color.Green;


                //string tenban = newbtn.Text;
                //String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(link);
                //sqlConnection.Open();
                //SqlCommand newcd = new SqlCommand();
                //newcd.Connection = sqlConnection;
                //newcd.CommandText = "UPDATE Ban SET Trangthai = N'Trống' WHERE TenBan like  N'%" + tenban + "%'";
                //newcd.ExecuteNonQuery();
                //sqlConnection.Close();
                
                string tenban = newbtn.Text;
                 f1.lb_ChonBan.Text = tenban;
                f1.loaddata();
                this.Hide();

            }    
                

        }
    }
}
