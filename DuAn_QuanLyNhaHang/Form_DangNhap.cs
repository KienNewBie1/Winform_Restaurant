using System.Data.SqlClient;

namespace DuAn_QuanLyNhaHang
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
            // nếu người dùng bấm vào chữ đăng ký thì hiện ra form đăng ký
        {
            Form_DangKy form_DangKy = new Form_DangKy();
            this.Hide();    
            form_DangKy.Show();
        }
        private void setTrangThaiKhongHoatDong()
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE TaiKhoanNhanVien SET TrangThai = 1 WHERE MaNV = @MaNV";
            cmd.Connection = sqlConnection;
            cmd.Parameters.AddWithValue("@MaNV", tb_TenDangNhap.Text);
            var check = cmd.ExecuteReader();
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //xóa bỏ toàn bộ error
            errorP_MatKhau.Clear();
            errorPr_TenDangNhap.Clear();
            // kiểm tra nếu ô tên đăng nhập bị bỏ trống thì hiển thị lỗi
            if (tb_TenDangNhap.Text == "")
            {
                errorPr_TenDangNhap.SetError(tb_TenDangNhap, "Không được bỏ trống ô này");
            }
            // kiểm tra nếu ô mật khẩu bị bỏ trống thì hiển thị lỗi
            if(tb_MatKhau.Text == "")
            {
                errorP_MatKhau.SetError(tb_MatKhau, "Không được bỏ trống ô này");
            }  
            // kiểm tra nếu người dùng bấm vào radiobutton nhân viên thì hiện from quản lý cho nhân viên
            
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT MaNV, MatKhau
                                FROM     TaiKhoanNhanVien
                                WHERE  (MaNV = @MaNV) AND (MatKhau = @matkhau)";
            cmd.Connection = sqlConnection;
            cmd.Parameters.AddWithValue("@MaNV", tb_TenDangNhap.Text);
            cmd.Parameters.AddWithValue("@matkhau", tb_MatKhau.Text);
            var check = cmd.ExecuteReader();
            if(check.Read())
            {
                if (radioB_Nhanvien.Checked)
                {
                    this.Hide();
                    Form_TrangChu form_TrangChu = new Form_TrangChu();
                    form_TrangChu.Show();
                }
                else if (radioB_QuanLy.Checked)
                {
                    this.Hide();
                   QuanLy quanLy = new QuanLy();
                    quanLy.Show();
                }

            }
            else
            {
                MessageBox.Show( "vui lòng nhập lại tài khoản và mật khẩu");
                
            }
            sqlConnection.Close();
            setTrangThaiKhongHoatDong();
        }

        private void tb_TenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_show_Click(object sender, EventArgs e)
        {
            pb_hienthi.BringToFront();
            tb_MatKhau.PasswordChar = '\0';
        }

        private void pb_hienthi_Click(object sender, EventArgs e)
        {
            pb_an.BringToFront();
            tb_MatKhau.PasswordChar = '*';
        }
        private void setTrangThaiHoatdong()
        {
            String link = @"Data Source=PHUC\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(link);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE TaiKhoanNhanVien SET TrangThai = 0 ";
            cmd.Connection = sqlConnection;
            var check = cmd.ExecuteReader();
        }
        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            setTrangThaiHoatdong();
        }
    }
}