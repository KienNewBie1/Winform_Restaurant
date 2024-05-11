using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn_QuanLyNhaHang
{
    public partial class UserQuanLyMonAn : UserControl
    {
        public UserQuanLyMonAn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void loaddata()
        {
            string link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(link);
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT TenMon,GiaTien,Loai,MaMon  FROM     DsMon", link);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dsMon");
            dataGridView_DSMon.DataSource = ds.Tables["dsMon"];
            dataGridView_DSMon.Columns["TenMon"].Width = 250;
            conn.Close();
        }
        private void UserQuanLyMonAn_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void selectIMG(string MaMonAn)
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT image
                                FROM     DsMon
                                WHERE  MaMon = @MaMonAn";
            cmd.Connection = sqlConnection;
            cmd.Parameters.AddWithValue("@MaMonAn", MaMonAn);
            var r = cmd.ExecuteScalar();
            Byte[] data = new Byte[0];
            data = (Byte[])(r);
            MemoryStream mem = new MemoryStream(data);
            pB_AnhMon.Image = Image.FromStream(mem);
            sqlConnection.Close();
        }
        string MaMonAn;

        private void dataGridView_DSMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            tb_TenMon.Text = dataGridView_DSMon.Rows[index].Cells[0].Value + "";
            tb_GiaMon.Text = dataGridView_DSMon.Rows[index].Cells[1].Value + "";
            tb_PhanLoai.Text = dataGridView_DSMon.Rows[index].Cells[2].Value + "";
            tb_MaMonAn.Text = dataGridView_DSMon.Rows[index].Cells[3].Value + "";
            selectIMG(tb_MaMonAn.Text);
            MaMonAn = dataGridView_DSMon.Rows[index].Cells[3].Value + "";
        }

        //private void HienAnh(string mamon)
        //{
        //    string linkImage = "";
        //    String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(link);
        //    sqlConnection.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = @"SELECT image
        //                        FROM     DsMon
        //                        WHERE  (MaMon = " + mamon + ")";
        //    cmd.Connection = sqlConnection;
        //    var r = cmd.ExecuteReader();
        //    if (r.Read())
        //    {
        //       pB_AnhMon.Image = new Bitmap(r[0]); ;
        //    }
        //}
        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pB_AnhMon.Image = new Bitmap(open.FileName);
                // image file path  


            }
            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand newcd = new SqlCommand();
            MemoryStream mem = new MemoryStream();
            pB_AnhMon.Image.Save(mem, pB_AnhMon.Image.RawFormat);
            newcd.Connection = sqlConnection;
            newcd.CommandText = "UPDATE DsMon SET image = @image WHERE MaMon = @MaMon";
            newcd.Parameters.AddWithValue("@image", mem.ToArray());
            newcd.Parameters.AddWithValue("@MaMon", MaMonAn);
            newcd.ExecuteNonQuery();
            loaddata();
            sqlConnection.Close();
        }

        private  bool kt(string Tenmon,string MaMon)
        {
            bool kiemTra = true;
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT TenMon
                                FROM     DsMon
                                WHERE ( TenMon like  N'%"+ Tenmon + "%') or ( MaMon like  N'%"+ MaMon + "%') ";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteScalar();
            if (r ==null)
            {
                kiemTra = false;
            }
            sqlConnection.Close ();
            return kiemTra;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(kt(tb_TenMon.Text,tb_MaMonAn.Text))
            {
                MessageBox.Show("Món ăn này đã có trong thực đơn của nhà hàng, vui lòng kiểm tra lại tên món hoặc mã món ăn","lỗi thêm món",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
            else
            {
                String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(link);
                sqlConnection.Open();
                SqlCommand newcd = new SqlCommand();
                MemoryStream mem = new MemoryStream();
                pB_AnhMon.Image.Save(mem, pB_AnhMon.Image.RawFormat);
                newcd.Connection = sqlConnection;
                newcd.CommandText = "INSERT INTO DsMon (TenMon, GiaTien, image,Loai,MaMon) VALUES (@TenMon, @GiaTien, @image,@Loai,@MaMon)";
                newcd.Parameters.AddWithValue("@TenMon", tb_TenMon.Text);
                newcd.Parameters.AddWithValue("@GiaTien", tb_GiaMon.Text);
                newcd.Parameters.AddWithValue("@image", mem.ToArray());
                newcd.Parameters.AddWithValue("@Loai", tb_PhanLoai.Text);
                newcd.Parameters.AddWithValue("@MaMon",tb_MaMonAn.Text);
                newcd.ExecuteNonQuery();
                loaddata();
                sqlConnection.Close();
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand newcd = new SqlCommand();
            newcd.Connection = sqlConnection;
            newcd.CommandText = @" DELETE FROM DsMon WHERE MaMon = @MaMon";
            newcd.Parameters.AddWithValue("@MaMon", tb_MaMonAn.Text);
            newcd.ExecuteNonQuery();
            loaddata();
            sqlConnection.Close();
            tb_TenMon.Text =  "";
            tb_GiaMon.Text =  "";
            tb_PhanLoai.Text =  "";
            tb_MaMonAn.Text =  "";
            pB_AnhMon.Image = null;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand newcd = new SqlCommand();
            MemoryStream mem = new MemoryStream();
            pB_AnhMon.Image.Save(mem, pB_AnhMon.Image.RawFormat);
            newcd.Connection = sqlConnection;
            newcd.CommandText = "UPDATE DsMon SET TenMon = @TenMon, GiaTien = @GiaTien, image = @image, Loai = @Loai, MaMon = @MaMon WHERE MaMon = @MaMonhientai ";
            newcd.Parameters.AddWithValue("@TenMon", tb_TenMon.Text);
            newcd.Parameters.AddWithValue("@GiaTien", tb_GiaMon.Text);
            newcd.Parameters.AddWithValue("@image", mem.ToArray());
            newcd.Parameters.AddWithValue("@Loai", tb_PhanLoai.Text);
            newcd.Parameters.AddWithValue("@MaMon", tb_MaMonAn.Text);
            newcd.Parameters.AddWithValue("@MaMonhientai", MaMonAn);
            newcd.ExecuteNonQuery();
            loaddata();
            sqlConnection.Close();
        }
    }
}
