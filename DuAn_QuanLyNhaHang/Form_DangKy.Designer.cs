namespace DuAn_QuanLyNhaHang
{
    partial class Form_DangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangKy));
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorP_tendangnhap = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_matkhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_sdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_QuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tendangnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_matkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_sdt)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MatKhau.Location = new System.Drawing.Point(620, 184);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(234, 34);
            this.tb_MatKhau.TabIndex = 10;
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_TenDangNhap.Location = new System.Drawing.Point(620, 89);
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.Size = new System.Drawing.Size(234, 34);
            this.tb_TenDangNhap.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(620, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 588);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Tomato;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Location = new System.Drawing.Point(765, 486);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(154, 44);
            this.btn_DangNhap.TabIndex = 13;
            this.btn_DangNhap.Text = "ĐĂNG KÝ";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(620, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "MẬT KHẨU";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_sdt.Location = new System.Drawing.Point(620, 374);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(234, 34);
            this.tb_sdt.TabIndex = 18;
            this.tb_sdt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_HoTen.Location = new System.Drawing.Point(620, 279);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(234, 34);
            this.tb_HoTen.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(620, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "HỌ TÊN";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(620, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "SỐ ĐIỆN THOẠI";
            // 
            // errorP_tendangnhap
            // 
            this.errorP_tendangnhap.ContainerControl = this;
            // 
            // errorP_matkhau
            // 
            this.errorP_matkhau.ContainerControl = this;
            // 
            // errorP_email
            // 
            this.errorP_email.ContainerControl = this;
            // 
            // errorP_sdt
            // 
            this.errorP_sdt.ContainerControl = this;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.Tomato;
            this.btn_QuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuayLai.FlatAppearance.BorderSize = 0;
            this.btn_QuayLai.ForeColor = System.Drawing.Color.Black;
            this.btn_QuayLai.Location = new System.Drawing.Point(554, 486);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(154, 44);
            this.btn_QuayLai.TabIndex = 21;
            this.btn_QuayLai.Text = "QUAY LẠI";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // Form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1021, 588);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_HoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DangKy";
            this.Text = "Đăng Ký";
            this.Load += new System.EventHandler(this.Form_DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tendangnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_matkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_sdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_MatKhau;
        private TextBox tb_TenDangNhap;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_DangNhap;
        private Label label2;
        private TextBox tb_sdt;
        private TextBox tb_HoTen;
        private Label label3;
        private Label label4;
        private ErrorProvider errorP_tendangnhap;
        private ErrorProvider errorP_matkhau;
        private ErrorProvider errorP_email;
        private ErrorProvider errorP_sdt;
        private Button btn_QuayLai;
    }
}