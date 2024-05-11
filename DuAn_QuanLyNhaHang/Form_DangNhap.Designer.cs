namespace DuAn_QuanLyNhaHang
{
    partial class Form_DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            this.tb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioB_Nhanvien = new System.Windows.Forms.RadioButton();
            this.radioB_QuanLy = new System.Windows.Forms.RadioButton();
            this.errorPr_TenDangNhap = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_MatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pb_an = new System.Windows.Forms.PictureBox();
            this.pb_hienthi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPr_TenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_MatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_an)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_TenDangNhap.Location = new System.Drawing.Point(605, 166);
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.Size = new System.Drawing.Size(234, 34);
            this.tb_TenDangNhap.TabIndex = 1;
            this.tb_TenDangNhap.TextChanged += new System.EventHandler(this.tb_TenDangNhap_TextChanged);
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MatKhau.Location = new System.Drawing.Point(605, 255);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '*';
            this.tb_MatKhau.Size = new System.Drawing.Size(234, 34);
            this.tb_MatKhau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(605, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(605, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "MẬT KHẨU";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Tomato;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Location = new System.Drawing.Point(643, 387);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(154, 44);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "ĐĂNG NHẬP";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(565, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bạn đã có tài khoản chưa ?";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(791, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đăng ký";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 588);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // radioB_Nhanvien
            // 
            this.radioB_Nhanvien.AutoSize = true;
            this.radioB_Nhanvien.Location = new System.Drawing.Point(610, 346);
            this.radioB_Nhanvien.Name = "radioB_Nhanvien";
            this.radioB_Nhanvien.Size = new System.Drawing.Size(98, 24);
            this.radioB_Nhanvien.TabIndex = 9;
            this.radioB_Nhanvien.TabStop = true;
            this.radioB_Nhanvien.Text = "Nhân Viên";
            this.radioB_Nhanvien.UseVisualStyleBackColor = true;
            // 
            // radioB_QuanLy
            // 
            this.radioB_QuanLy.AutoSize = true;
            this.radioB_QuanLy.Location = new System.Drawing.Point(741, 346);
            this.radioB_QuanLy.Name = "radioB_QuanLy";
            this.radioB_QuanLy.Size = new System.Drawing.Size(82, 24);
            this.radioB_QuanLy.TabIndex = 10;
            this.radioB_QuanLy.TabStop = true;
            this.radioB_QuanLy.Text = "Quản Lý";
            this.radioB_QuanLy.UseVisualStyleBackColor = true;
            // 
            // errorPr_TenDangNhap
            // 
            this.errorPr_TenDangNhap.ContainerControl = this;
            // 
            // errorP_MatKhau
            // 
            this.errorP_MatKhau.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(732, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quên mật khẩu";
            // 
            // pb_an
            // 
            this.pb_an.Image = ((System.Drawing.Image)(resources.GetObject("pb_an.Image")));
            this.pb_an.Location = new System.Drawing.Point(845, 253);
            this.pb_an.Name = "pb_an";
            this.pb_an.Size = new System.Drawing.Size(30, 36);
            this.pb_an.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_an.TabIndex = 12;
            this.pb_an.TabStop = false;
            this.pb_an.Click += new System.EventHandler(this.pb_show_Click);
            // 
            // pb_hienthi
            // 
            this.pb_hienthi.Image = ((System.Drawing.Image)(resources.GetObject("pb_hienthi.Image")));
            this.pb_hienthi.Location = new System.Drawing.Point(845, 253);
            this.pb_hienthi.Name = "pb_hienthi";
            this.pb_hienthi.Size = new System.Drawing.Size(30, 36);
            this.pb_hienthi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_hienthi.TabIndex = 13;
            this.pb_hienthi.TabStop = false;
            this.pb_hienthi.Click += new System.EventHandler(this.pb_hienthi_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1021, 588);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioB_QuanLy);
            this.Controls.Add(this.radioB_Nhanvien);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_an);
            this.Controls.Add(this.pb_hienthi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPr_TenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_MatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_an)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_TenDangNhap;
        private TextBox tb_MatKhau;
        private Label label1;
        private Label label2;
        private Button btn_DangNhap;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private RadioButton radioB_Nhanvien;
        private RadioButton radioB_QuanLy;
        private ErrorProvider errorPr_TenDangNhap;
        private ErrorProvider errorP_MatKhau;
        private Label label5;
        private PictureBox pb_an;
        private PictureBox pb_hienthi;
    }
}