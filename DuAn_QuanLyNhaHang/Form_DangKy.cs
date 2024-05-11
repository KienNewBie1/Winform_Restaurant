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

namespace DuAn_QuanLyNhaHang
{
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
        }

        private void themDuLieuVaoNV()
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand newcd = new SqlCommand();
            newcd.Connection = sqlConnection;
            newcd.CommandText = "INSERT INTO NhanVien(MaNV, TenNV,SDT) VALUES (@MaNV,@tennv, @sodienthoai)";
            newcd.Parameters.AddWithValue("@MaNV", tb_TenDangNhap.Text);
            newcd.Parameters.AddWithValue("@tennv", tb_HoTen.Text);
            newcd.Parameters.AddWithValue("@sodienthoai", tb_sdt.Text);
            newcd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            errorP_tendangnhap.Clear();
            errorP_matkhau.Clear();
            errorP_email.Clear();
            errorP_sdt.Clear();
            if (tb_TenDangNhap.Text == "")
            {
                errorP_tendangnhap.SetError(tb_TenDangNhap, "Không được để trống ô này");
            }
            if (tb_MatKhau.Text == "")
            {
                errorP_matkhau.SetError(tb_MatKhau, "Không được để trống ô này");
            }
            if (tb_HoTen.Text == "")
            {
                errorP_email.SetError(tb_HoTen, "Không được để trống ô này");
            }
            if (tb_sdt.Text == "")
            {
                errorP_sdt.SetError(tb_sdt, "Không được để trống ô này");
            }
            if(tb_TenDangNhap.Text != ""&& tb_MatKhau.Text != ""&& tb_HoTen.Text != ""&& tb_sdt.Text != "")
            {
                String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(link);
                sqlConnection.Open();
                SqlCommand newcd = new SqlCommand();
                newcd.Connection = sqlConnection;
                newcd.CommandText = "INSERT INTO TaiKhoanNhanVien(MaNV, MatKhau) VALUES (@MaNV,@matkhau)";
                newcd.Parameters.AddWithValue("@MaNV", tb_TenDangNhap.Text);
                newcd.Parameters.AddWithValue("@matkhau", tb_MatKhau.Text);
                newcd.ExecuteNonQuery();
                
                sqlConnection.Close();
                themDuLieuVaoNV();
                Form_DangNhap form_DangNhap = new Form_DangNhap();
                this.Hide();
                form_DangNhap.Show();
            }    
            
        }

        private void Form_DangKy_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
