namespace DuAn_QuanLyNhaHang
{
    partial class UserQuanLyMonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_MaMonAn = new System.Windows.Forms.TextBox();
            this.btn_chonAnh = new System.Windows.Forms.Button();
            this.pB_AnhMon = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_PhanLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_GiaMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TenMon = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dataGridView_DSMon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_AnhMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(744, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách món ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_MaMonAn);
            this.panel1.Controls.Add(this.btn_chonAnh);
            this.panel1.Controls.Add(this.pB_AnhMon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_PhanLoai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_GiaMon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_TenMon);
            this.panel1.Location = new System.Drawing.Point(916, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 572);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã Món Ăn";
            // 
            // tb_MaMonAn
            // 
            this.tb_MaMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_MaMonAn.Location = new System.Drawing.Point(34, 287);
            this.tb_MaMonAn.Name = "tb_MaMonAn";
            this.tb_MaMonAn.Size = new System.Drawing.Size(250, 27);
            this.tb_MaMonAn.TabIndex = 10;
            this.tb_MaMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_chonAnh
            // 
            this.btn_chonAnh.Location = new System.Drawing.Point(34, 531);
            this.btn_chonAnh.Name = "btn_chonAnh";
            this.btn_chonAnh.Size = new System.Drawing.Size(250, 29);
            this.btn_chonAnh.TabIndex = 8;
            this.btn_chonAnh.Text = "chọn Ảnh Món";
            this.btn_chonAnh.UseVisualStyleBackColor = true;
            this.btn_chonAnh.Click += new System.EventHandler(this.btn_chonAnh_Click);
            // 
            // pB_AnhMon
            // 
            this.pB_AnhMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_AnhMon.Location = new System.Drawing.Point(34, 349);
            this.pB_AnhMon.Name = "pB_AnhMon";
            this.pB_AnhMon.Size = new System.Drawing.Size(250, 167);
            this.pB_AnhMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_AnhMon.TabIndex = 7;
            this.pB_AnhMon.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ảnh Món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phân Loại Món Ăn";
            // 
            // tb_PhanLoai
            // 
            this.tb_PhanLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PhanLoai.Location = new System.Drawing.Point(34, 219);
            this.tb_PhanLoai.Name = "tb_PhanLoai";
            this.tb_PhanLoai.Size = new System.Drawing.Size(250, 27);
            this.tb_PhanLoai.TabIndex = 4;
            this.tb_PhanLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá Món Ăn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_GiaMon
            // 
            this.tb_GiaMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_GiaMon.Location = new System.Drawing.Point(34, 152);
            this.tb_GiaMon.Name = "tb_GiaMon";
            this.tb_GiaMon.Size = new System.Drawing.Size(250, 27);
            this.tb_GiaMon.TabIndex = 2;
            this.tb_GiaMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Món Ăn";
            // 
            // tb_TenMon
            // 
            this.tb_TenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TenMon.Location = new System.Drawing.Point(34, 89);
            this.tb_TenMon.Name = "tb_TenMon";
            this.tb_TenMon.Size = new System.Drawing.Size(250, 27);
            this.tb_TenMon.TabIndex = 0;
            this.tb_TenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(48, 570);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(184, 40);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(331, 570);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(184, 40);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(608, 570);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(184, 40);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dataGridView_DSMon
            // 
            this.dataGridView_DSMon.AllowUserToAddRows = false;
            this.dataGridView_DSMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSMon.Location = new System.Drawing.Point(59, 92);
            this.dataGridView_DSMon.Name = "dataGridView_DSMon";
            this.dataGridView_DSMon.RowHeadersWidth = 51;
            this.dataGridView_DSMon.RowTemplate.Height = 50;
            this.dataGridView_DSMon.Size = new System.Drawing.Size(720, 450);
            this.dataGridView_DSMon.TabIndex = 6;
            this.dataGridView_DSMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSMon_CellClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 42);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chi tiết món ăn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_DSMon);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserQuanLyMonAn";
            this.Size = new System.Drawing.Size(1296, 623);
            this.Load += new System.EventHandler(this.UserQuanLyMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_AnhMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox tb_PhanLoai;
        private Label label3;
        private TextBox tb_GiaMon;
        private Label label2;
        private TextBox tb_TenMon;
        private Button btn_Them;
        private Button btn_sua;
        private Button btn_xoa;
        private DataGridView dataGridView_DSMon;
        private PictureBox pB_AnhMon;
        private Label label5;
        private Button btn_chonAnh;
        private Label label6;
        private TextBox tb_MaMonAn;
        private Label label7;
    }
}
