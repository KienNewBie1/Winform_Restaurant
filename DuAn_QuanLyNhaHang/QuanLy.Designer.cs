namespace DuAn_QuanLyNhaHang
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_MonAn = new System.Windows.Forms.Button();
            this.panel_HienThi = new System.Windows.Forms.Panel();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1602, 48);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1602, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baratie restaurant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_QuayLai);
            this.panel2.Controls.Add(this.btn_ThongKe);
            this.panel2.Controls.Add(this.btn_MonAn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 706);
            this.panel2.TabIndex = 1;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.Location = new System.Drawing.Point(25, 25);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(170, 65);
            this.btn_ThongKe.TabIndex = 8;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            this.btn_ThongKe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_ThongKe_MouseClick);
            this.btn_ThongKe.MouseHover += new System.EventHandler(this.btn_ThongKe_MouseHover);
            // 
            // btn_MonAn
            // 
            this.btn_MonAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_MonAn.Image")));
            this.btn_MonAn.Location = new System.Drawing.Point(25, 128);
            this.btn_MonAn.Name = "btn_MonAn";
            this.btn_MonAn.Size = new System.Drawing.Size(170, 76);
            this.btn_MonAn.TabIndex = 7;
            this.btn_MonAn.Text = "Quản Lý Món Ăn";
            this.btn_MonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MonAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MonAn.UseVisualStyleBackColor = true;
            this.btn_MonAn.Click += new System.EventHandler(this.btn_MonAn_Click);
            // 
            // panel_HienThi
            // 
            this.panel_HienThi.BackColor = System.Drawing.Color.White;
            this.panel_HienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_HienThi.Location = new System.Drawing.Point(223, 48);
            this.panel_HienThi.Name = "panel_HienThi";
            this.panel_HienThi.Size = new System.Drawing.Size(1379, 706);
            this.panel_HienThi.TabIndex = 1;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_QuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuayLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QuayLai.ForeColor = System.Drawing.Color.White;
            this.btn_QuayLai.Location = new System.Drawing.Point(0, 642);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(221, 64);
            this.btn_QuayLai.TabIndex = 61;
            this.btn_QuayLai.Text = "QUAY LẠI";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 754);
            this.Controls.Add(this.panel_HienThi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLy";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel_HienThi;
        private Label label2;
        private Button btn_ThongKe;
        private Button btn_MonAn;
        private Button btn_QuayLai;
    }
}