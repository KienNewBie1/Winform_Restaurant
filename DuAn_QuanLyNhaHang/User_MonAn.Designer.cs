namespace DuAn_QuanLyNhaHang
{
    partial class User_MonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_MonAn));
            this.lb_TenMon = new System.Windows.Forms.Label();
            this.pb_AnhMon = new System.Windows.Forms.PictureBox();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TenMon
            // 
            this.lb_TenMon.AutoSize = true;
            this.lb_TenMon.BackColor = System.Drawing.Color.White;
            this.lb_TenMon.Location = new System.Drawing.Point(22, 6);
            this.lb_TenMon.Name = "lb_TenMon";
            this.lb_TenMon.Size = new System.Drawing.Size(56, 20);
            this.lb_TenMon.TabIndex = 20;
            this.lb_TenMon.Text = "bún bò";
            this.lb_TenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_AnhMon
            // 
            this.pb_AnhMon.BackColor = System.Drawing.Color.Transparent;
            this.pb_AnhMon.Image = ((System.Drawing.Image)(resources.GetObject("pb_AnhMon.Image")));
            this.pb_AnhMon.Location = new System.Drawing.Point(27, 29);
            this.pb_AnhMon.Name = "pb_AnhMon";
            this.pb_AnhMon.Size = new System.Drawing.Size(175, 125);
            this.pb_AnhMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AnhMon.TabIndex = 16;
            this.pb_AnhMon.TabStop = false;
            this.pb_AnhMon.Click += new System.EventHandler(this.User_MonAn_Click);
            this.pb_AnhMon.DoubleClick += new System.EventHandler(this.pb_AnhMon_DoubleClick);
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.BackColor = System.Drawing.Color.White;
            this.lb_Gia.Location = new System.Drawing.Point(109, 169);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(44, 20);
            this.lb_Gia.TabIndex = 18;
            this.lb_Gia.Text = "10.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giá : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.User_MonAn_Click);
            // 
            // User_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_AnhMon);
            this.Controls.Add(this.lb_Gia);
            this.Controls.Add(this.lb_TenMon);
            this.Name = "User_MonAn";
            this.Size = new System.Drawing.Size(232, 241);
            this.Load += new System.EventHandler(this.User_MonAn_Load);
            this.Click += new System.EventHandler(this.User_MonAn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_TenMon;
        private PictureBox pb_AnhMon;
        private Label lb_Gia;
        private Label label1;
        private Button button1;
    }
}
