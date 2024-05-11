namespace DuAn_QuanLyNhaHang
{
    partial class Ban
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
            this.fl_DS_Ban = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fl_DS_Ban
            // 
            this.fl_DS_Ban.AutoScroll = true;
            this.fl_DS_Ban.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fl_DS_Ban.Location = new System.Drawing.Point(12, 12);
            this.fl_DS_Ban.Name = "fl_DS_Ban";
            this.fl_DS_Ban.Size = new System.Drawing.Size(641, 392);
            this.fl_DS_Ban.TabIndex = 0;
            // 
            // Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 418);
            this.Controls.Add(this.fl_DS_Ban);
            this.Name = "Ban";
            this.Text = "Danh Sách Bàn";
            this.Load += new System.EventHandler(this.Ban_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel fl_DS_Ban;
    }
}