using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyNhaHang
{
    public partial class UserC_ThongKe : UserControl
    {
        public UserC_ThongKe()
        {
            InitializeComponent();
        }

        private void Tongtien_Ngay_Click(object sender, EventArgs e)
        {

        }
        
        private void NhanDuLieuNhanVienVaBanTongGia()
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT NhanVien.TenNV, HoaDon.Ban,TongGia
                                FROM     HoaDon INNER JOIN
                                NhanVien ON HoaDon.MaNV = NhanVien.MaNV
                                WHERE  (HoaDon.MaHoaDon = " + tb_TimKiemMaHoaDon.Text+" )";
            cmd.Connection = sqlConnection;
            
                var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lb_NhanVien.Text = "Nhân Viên Phục Vụ : " + r[0];
                    lb_Ban.Text = "Bàn : " + r[1];
                lb_tongGia.Text = "Tổng Giá : " + r[2];
                }
                
            
            sqlConnection.Close();
        }
        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            if(tb_TimKiemMaHoaDon.Text != "")
            {
                NhanDuLieuNhanVienVaBanTongGia();
                string link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
                SqlConnection conn = new SqlConnection(link);
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Ten, Gia, SoLuong\r\nFROM     CT_Hoadon\r\nWHERE  (MaHoaDon = " + tb_TimKiemMaHoaDon.Text + ")", link);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "CT_hoaDon");
                if (ds.Tables["CT_hoaDon"].Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu, Vui lòng nhập lại mã hóa đơn");
                }
                else
                {

                    dataGridView_CT_HD.DataSource = ds.Tables["CT_hoaDon"];
                    dataGridView_CT_HD.Columns["Ten"].Width = 200;
                    dataGridView_CT_HD.Columns["SoLuong"].Width = 75;
                    dataGridView_CT_HD.Columns["Ten"].HeaderText = "Tên Món";
                    dataGridView_CT_HD.Columns["Gia"].HeaderText = "Giá";
                    dataGridView_CT_HD.Columns["SoLuong"].HeaderText = "Số Lượng";
                }
                
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
            
        }
        private void loaddata()
        {

            string link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(link);
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT  HoaDon.MaHoaDon, HoaDon.TongGia, HoaDon.Ban, HoaDon.NgayLap, HoaDon.GioLap, NhanVien.TenNV\r\nFROM     HoaDon INNER JOIN\r\n                  NhanVien ON HoaDon.MaNV = NhanVien.MaNV ORDER BY HoaDon.MaHoaDon", link);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dsmondachon");
            dataGridView_ThongKe.DataSource = ds.Tables["dsmondachon"];
            dataGridView_ThongKe.Columns["TenNV"].Width = 200;
            dataGridView_ThongKe.Columns["MaHoaDon"].Width = 94;
            dataGridView_ThongKe.Columns["MaHoaDon"].HeaderText = "Mã HĐ";
            dataGridView_ThongKe.Columns["TongGia"].HeaderText = "Tổng Giá";
            dataGridView_ThongKe.Columns["Ban"].HeaderText = "Bàn";
            dataGridView_ThongKe.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dataGridView_ThongKe.Columns["GioLap"].HeaderText = "Giờ Lập";
            dataGridView_ThongKe.Columns["TenNV"].HeaderText = "Lập Bởi Nhân Viên";










            //SqlCommand sqlcommand = new SqlCommand();
            //sqlcommand.CommandType = CommandType.Text;
            //sqlcommand.Connection = conn;
            //sqlcommand.CommandText = "select sum(gia * soluong) as soluongnha\r\nfrom     ds_mondachon";
            //var reader = sqlcommand.ExecuteScalar();
            //if (reader == null)
            //{
            //    lb_tonggia.Text = 0 + " ";
            //}
            //else
            //{
            //    lb_tonggia.Text = reader.ToString();
            //}
            conn.Close();

        }
        private void UserC_ThongKe_Load(object sender, EventArgs e)
        {
            loaddata();
            Tongtien_Ngay.Text = TongThuNhapNgay()+" VNĐ";
            Tongtien_Thang.Text = TongThuNhapThang() + " VNĐ";
            Tongtien_Nam.Text = TongThuNhapNam() + " VNĐ";
        }
        private float TongThuNhapNam()
        {
            float TongGia = 0;
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select SUM(TongGia) from HoaDon 
            where YEAR(NgayLap) = YEAR(GETDATE())";
            cmd.Connection = sqlConnection;
            var result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int tong = Convert.ToInt32(result);
            TongGia = tong;
            sqlConnection.Close();
            return TongGia;
        }
        private float TongThuNhapThang()
        {
            float TongGia = 0;
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select SUM(TongGia) from HoaDon 
            where MONTH(NgayLap) = MONTH(GETDATE())";
            cmd.Connection = sqlConnection;
            var result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int tong = Convert.ToInt32(result);
            TongGia = tong;
            sqlConnection.Close();
            return TongGia;
        }
        private float TongThuNhapNgay()
        {
            float TongGia = 0;
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select SUM(TongGia) from HoaDon 
            where NgayLap = CAST( GETDATE() AS Date )";
            cmd.Connection = sqlConnection;
            var result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int tong = Convert.ToInt32(result);
            TongGia = tong;
            sqlConnection.Close();
            return TongGia;
        }

        private void dataGridView_ThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(link);
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Ten, Gia, SoLuong\r\nFROM     CT_Hoadon\r\nWHERE  (MaHoaDon = " + dataGridView_ThongKe.Rows[index].Cells[0].Value + ")", link);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "CT_hoaDon");
            dataGridView_CT_HD.DataSource = ds.Tables["CT_hoaDon"];
            dataGridView_CT_HD.Columns["Ten"].Width = 200;
            dataGridView_CT_HD.Columns["SoLuong"].Width = 75;
            dataGridView_CT_HD.Columns["Ten"].HeaderText = "Tên Món";
            dataGridView_CT_HD.Columns["Gia"].HeaderText = "Giá";
            dataGridView_CT_HD.Columns["SoLuong"].HeaderText = "Số Lượng";
         }
    }
}
