using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyNhaHang
{
    public partial class Form_TrangChu : Form
    {
        
        public Form_TrangChu()
        {
            InitializeComponent();
        }
        
        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.Show();


            
        }

        private void Form_TrangChu_Load(object sender, EventArgs e)
        {
            loaddatatrangchu();
            loaddata();

            // làm thêm

            //String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            //SqlConnection sqlConnection = new SqlConnection(link);
            //sqlConnection.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = @"SELECT * FROM  Ban";
            //cmd.Connection = sqlConnection;
            //var r = cmd.ExecuteReader();
            //while (r.Read())
            //{
            //    cb_ChonBan.Items.Add(r[0] +" "+ r[2]);
    
            //}
            //sqlConnection.Close();
        }

        private void loaddatatrangchu()
        {
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM  DsMon";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                User_MonAn user_MonAn = new User_MonAn();
                user_MonAn.Tenmon = r[0] + "";
                user_MonAn.Gia = r[1] + "";
               
                // load ảnh từ trên sql về picture box
                Byte[] data = new Byte[0];
                data = (Byte[])(r[2]);
                MemoryStream mem = new MemoryStream(data);
                user_MonAn.img = Image.FromStream(mem);

                Fl_container.Controls.Add(user_MonAn);
                user_MonAn.buttonclick += new EventHandler(them);
            }
            sqlConnection.Close();
            
        } 

        private bool kiemtra(string TenMon)
        {
            bool kt = true;
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT  SoLuong
                                FROM     DS_MonDaChon
                                WHERE  (Ten = N'"+ TenMon+ "')AND (Ban = N'"+ lb_ChonBan.Text+"')";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                kt = false;
            }
            return kt;
        }
        private bool KT_Rong_BangCT_HoaDon()
        {
            bool kt = true;
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM     CT_Hoadon";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                kt = false;
            }
            return kt;
        }
        private void setban(string tenmon)
        {
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
           

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"UPDATE DS_MonDaChon
                                    SET Ban = N'"+ lb_ChonBan.Text+ "' WHERE (Ten = @tenmonan) AND (Ban IS NULL) ";
                cmd.Parameters.AddWithValue("@tenmonan", tenmon);
                cmd.Connection = sqlConnection;
                cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        private void them(object  sender, EventArgs e)
        {
            User_MonAn user = (User_MonAn)((Button)sender).Parent;
            string tenmon = user.Tenmon+"";
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            //SqlCommand kiemtra = new SqlCommand();
            //kiemtra.CommandText = 
            if(lb_ChonBan.Text=="")
            {
                MessageBox.Show("Vui lòng chọn Bàn trước", "Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
            else
            {
                if (kiemtra(tenmon) == true)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = @"INSERT INTO DS_MonDaChon(Ten, Gia)
                                        SELECT TenMon, GiaTien
                                        FROM DsMon
                                        WHERE TenMon = @tenmonan ";
                    cmd.Parameters.AddWithValue("@tenmonan", tenmon);
                    cmd.Connection = sqlConnection;
                    cmd.ExecuteNonQuery();
                    setban(tenmon);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = @"UPDATE DS_MonDaChon 
                                    SET SoLuong = SoLuong+1 
                                        WHERE Ten= @tenmonan ";
                    cmd.Parameters.AddWithValue("@tenmonan", tenmon);
                    cmd.Connection = sqlConnection;
                    cmd.ExecuteNonQuery();
                }

                sqlConnection.Close();
                loaddata();
            }
            
            
        }
        // tải lại dữ liêu 

        private void capnhattien()
        {
            string link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection conn = new SqlConnection(link);
            conn.Open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = CommandType.Text;
            sqlcommand.Connection = conn;
            sqlcommand.CommandText = "select sum(gia * soluong) as soluongnha\r\nfrom     ds_mondachon WHERE Ban = N'" + lb_ChonBan.Text + "' ";
            var reader = sqlcommand.ExecuteScalar();
            if (reader.ToString() == "")
            {
                lb_tonggia.Text = 0 + "";
            }
            else
            {
                lb_tonggia.Text = reader.ToString();
                
            }
            conn.Close();
        }
        public void loaddata()
        {
            
            string link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection conn = new SqlConnection(link);
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DS_MonDaChon.* FROM DS_MonDaChon WHERE Ban = N'"+ lb_ChonBan.Text+ "'", link);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dsmondachon");
            dataG_DanhSachMonDaChon.DataSource = ds.Tables["dsmondachon"];
            dataG_DanhSachMonDaChon.Columns["Ten"].HeaderText = "Tên Món";
            dataG_DanhSachMonDaChon.Columns["Gia"].HeaderText = "Giá";
            dataG_DanhSachMonDaChon.Columns["SoLuong"].HeaderText = "Số Lượng";
            dataG_DanhSachMonDaChon.Columns["SoLuong"].Width = 100;
            // cập nhật tiền của hóa đơn
            capnhattien();

            lb_TenSanPham_DaChon.Text = "";
            tb_SoLuong_sp_DaChon.Text = "";
        }

      

        

        //public void themmon(String tenmonan)
        //{
           
        //    String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(link);
        //    sqlConnection.Open();
        //    //SqlCommand kiemtra = new SqlCommand();
        //    //kiemtra.CommandText = 
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = @"INSERT INTO DS_MonDaChon(Ten, Gia)
        //                                SELECT TenMon, GiaTien
        //                                FROM MonAn
        //                                WHERE TenMon = @tenmonan ";
        //    cmd.Parameters.AddWithValue("@tenmonan", tenmonan);

        //    cmd.Connection = sqlConnection;
        //    cmd.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    loaddata();

        //}

        
        
        private void btn_MonAn_Click(object sender, EventArgs e)
        {
            Fl_container.Controls.Clear();
            Button btn = (Button)sender;
            string mon = btn.Text+"";
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM     DsMon
                                WHERE  Loai = N'Món ăn'";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                User_MonAn user_MonAn = new User_MonAn();
                user_MonAn.Tenmon = r[0] + "";
                user_MonAn.Gia = r[1] + "";


                // load ảnh từ trên sql về picture box
                Byte[] data = new Byte[0];
                data = (Byte[])(r[2]);
                MemoryStream mem = new MemoryStream(data);
                user_MonAn.img = Image.FromStream(mem);

                Fl_container.Controls.Add(user_MonAn);
                user_MonAn.buttonclick += new EventHandler(them);
            }
            sqlConnection.Close();

        }

        private void btn_TatCa_Click(object sender, EventArgs e)
        {
            Fl_container.Controls.Clear();
            loaddatatrangchu();
        }

        private void btn_Ruou_Click(object sender, EventArgs e)
        {
            Fl_container.Controls.Clear();
            Button btn = (Button)sender;
            string mon = btn.Text + "";
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM     DsMon
                                WHERE  Loai = N'Rượu'";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                User_MonAn user_MonAn = new User_MonAn();
                user_MonAn.Tenmon = r[0] + "";
                user_MonAn.Gia = r[1] + "";

                // load ảnh từ trên sql về picture box
                Byte[] data = new Byte[0];
                data = (Byte[])(r[2]);
                MemoryStream mem = new MemoryStream(data);
                user_MonAn.img = Image.FromStream(mem);

                Fl_container.Controls.Add(user_MonAn);
                user_MonAn.buttonclick += new EventHandler(them);
            }
            sqlConnection.Close();
        }

        private void dataG_DanhSachMonDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = e.RowIndex;
            lb_TenSanPham_DaChon.Text = dataG_DanhSachMonDaChon.Rows[index].Cells[0].Value + "";
            tb_SoLuong_sp_DaChon.Text = dataG_DanhSachMonDaChon.Rows[index].Cells[2].Value + "";
        }
      

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            
            int soluongmon = int.Parse(tb_SoLuong_sp_DaChon.Text);
            string tenmon = lb_TenSanPham_DaChon.Text;
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand newcd = new SqlCommand();
            newcd.Connection = sqlConnection;
            newcd.CommandText = "UPDATE DS_MonDaChon SET SoLuong = @soluong WHERE ( Ten = @tenmon ) AND  ( Ban like N'%" + lb_ChonBan.Text + "%' )";
            newcd.Parameters.AddWithValue("@soluong", soluongmon);
            newcd.Parameters.AddWithValue("@tenmon", tenmon);
            newcd.ExecuteNonQuery();
            sqlConnection.Close();
            loaddata();

        }
        // xóa món ăn khỏi danh sách thanh toán
        private void btn_Xoa_Mon_Click(object sender, EventArgs e)
        {
            string link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(link);
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from ds_mondachon WHERE ( Ten = @ten ) AND  ( Ban like N'%" + lb_ChonBan.Text + "%' )";
            cmd.Parameters.AddWithValue("@ten", lb_TenSanPham_DaChon.Text);
            cmd.Connection = sqlconnection;
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            loaddata();
            tb_SoLuong_sp_DaChon.Text = "";
            lb_TenSanPham_DaChon.Text = "";
        }
        private void ChuyenDuLieuDS_Dachon_CT_HoaDon()
        {
            string link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(link);
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO CT_Hoadon(Ten, Gia,SoLuong,MaHoaDon,Ban)
                                        SELECT Ten, Gia,SoLuong,MaHoaDon,Ban
                                        FROM DS_MonDaChon
                                        Where Ban like  N'%" + lb_ChonBan.Text + "%'";
            cmd.Parameters.AddWithValue("@ten", lb_TenSanPham_DaChon.Text);
            cmd.Connection = sqlconnection;
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
        }

        private void ChuyenDuLieuCT_HoaDon_HoaDon()
        {
            string link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(link);
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO HoaDon(MaHoaDon,TongGia,NgayLap,GioLap,Ban,MaNV)                                         
                                SELECT MaHoaDon,sum(Gia),CAST(GETDATE() AS date),format(getdate(), 'hh:mm:ss tt'),Ban,(SELECT MaNV from TaiKhoanNhanVien where TrangThai = 1)
                                FROM     CT_Hoadon
                                where MaHoaDon = ( SELECT MaHoaDon From CT_Hoadon 
                                                    where  MaHoaDon not in (SELECT MaHoaDon From HoaDon )
                                                    group by MaHoaDon)
                                group by MaHoaDon,Ban";
           
            cmd.Connection = sqlconnection;
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
        }
        private bool kt_Rong_DS_Mon()
        {
            bool kt = true;
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM     ds_mondachon ";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            if(r.Read())
            {
                kt = false;
            }    
            return kt;
        }
        private void setMaHoaDon()
        {
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            if (KT_Rong_BangCT_HoaDon())
            {
                cmd.CommandText = @"
                    UPDATE DS_MonDaChon 
                    SET MaHoaDon = 1 ,Ban=@Ban WHERE Ban like  N'%" + lb_ChonBan.Text + "%' ";
                cmd.Parameters.AddWithValue("@Ban", lb_ChonBan.Text);
                
                cmd.Connection = sqlConnection;
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.CommandText = @"UPDATE DS_MonDaChon 
                    SET MaHoaDon = ((SELECT max (MaHoaDon)
                FROM     CT_Hoadon)+1),Ban=@Ban WHERE Ban like  N'%" + lb_ChonBan.Text + "%'";
                cmd.Parameters.AddWithValue("@Ban", lb_ChonBan.Text);
                cmd.Connection = sqlConnection;
                
                cmd.ExecuteNonQuery();
            }
            //cmd.Parameters.AddWithValue("@tenmonan", tenmon);
            
            sqlConnection.Close();
        }

        private void setMaNV()
        {
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"
                    UPDATE DS_MonDaChon 
                    SET MaHoaDon = 1 ,Ban=@Ban";
            cmd.Parameters.AddWithValue("@Ban", lb_ChonBan.Text);
            
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void settrangthaiban()
        {
            String links = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(links);
            sqlConn.Open();
            SqlCommand newcd = new SqlCommand();
            newcd.Connection = sqlConn;
            newcd.CommandText = "UPDATE Ban SET Trangthai = N'Trống' WHERE TenBan like   N'%" + lb_ChonBan.Text + "%'";
            newcd.ExecuteNonQuery();
            sqlConn.Close();
        }
        private void btn_tinhgtien_Click(object sender, EventArgs e)
        {
            
            if (lb_ChonBan.Text == "")
            {
                MessageBox.Show("vui lòng chọn bàn");

            }
            else
            {
                if(!kt_Rong_DS_Mon())
                {
                    
                    MessageBox.Show(lb_ChonBan.Text + "\n" + taohoadon() + "\n" + "Tổng tiền: " + lb_tonggia.Text);
                    setMaHoaDon();
                    ChuyenDuLieuDS_Dachon_CT_HoaDon();
                    ChuyenDuLieuCT_HoaDon_HoaDon();
                    String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(link);
                    sqlConnection.Open();

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = @"Delete from DS_MonDaChon WHERE Ban like  N'%" + lb_ChonBan.Text + "%'";
                    cmd.Connection = sqlConnection;
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    loaddata();
                    settrangthaiban();
                    lb_ChonBan.Text = "";
                    lb_TenSanPham_DaChon.Text = "";
                    tb_SoLuong_sp_DaChon.Text = "";
                }
                else
                {
                    MessageBox.Show("vui lòng chọn món");
                }


               

            }
           
        }
        private string taohoadon()
        {
            string hoadon="";
            int stt = 1;
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM  DS_MonDaChon Where Ban like N'%" + lb_ChonBan.Text + "%' ";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                hoadon += stt+":    " + "Tên món: "+r[0] + "          Giá: " + r[1] + "           Số Lượng: " + r[2]+"\n";
                stt++;
            }
            sqlConnection.Close();
            return hoadon;
        }
        

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            Fl_container.Controls.Clear();
           
            
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM     DsMon
                                WHERE  TenMon like N'"+tb_TimKiem.Text+"%'";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                User_MonAn user_MonAn = new User_MonAn();
                user_MonAn.Tenmon = r[0] + "";
                user_MonAn.Gia = r[1] + "";

                // load ảnh từ trên sql về picture box
                Byte[] data = new Byte[0];
                data = (Byte[])(r[2]);
                MemoryStream mem = new MemoryStream(data);
                user_MonAn.img = Image.FromStream(mem);

                Fl_container.Controls.Add(user_MonAn);
                user_MonAn.buttonclick += new EventHandler(them);
            }
            sqlConnection.Close();
        }

        private void btn_DoUongLanh_Click(object sender, EventArgs e)
        {
            Fl_container.Controls.Clear();
            Button btn = (Button)sender;
            string mon = btn.Text + "";
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM     DsMon
                                WHERE  Loai = N'Đồ Uống Lạnh'";
            cmd.Connection = sqlConnection;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                User_MonAn user_MonAn = new User_MonAn();
                user_MonAn.Tenmon = r[0] + "";
                user_MonAn.Gia = r[1] + "";


                // load ảnh từ trên sql về picture box
                Byte[] data = new Byte[0];
                data = (Byte[])(r[2]);
                MemoryStream mem = new MemoryStream(data);
                user_MonAn.img = Image.FromStream(mem);

                Fl_container.Controls.Add(user_MonAn);
                user_MonAn.buttonclick += new EventHandler(them);
            }
            sqlConnection.Close();
        }

        private void btn_ChonBan_Click(object sender, EventArgs e)
        {
            
            Ban ban = new Ban(this);
            ban.Show();
        }
        public string tenban { get; set; }
        public void setlb_ChonBan()
        {
            lb_ChonBan.Text = tenban;
        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
           
            String link = @"Data Source=DESKTOP-ROTP5SJ\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand newcd = new SqlCommand();
            newcd.Connection = sqlConnection;
            newcd.CommandText = "UPDATE Ban SET Trangthai = N'Đã chọn' WHERE TenBan like  N'%" + lb_ChonBan.Text + "%'";
            newcd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
