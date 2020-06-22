namespace QLNS.views
{
    partial class formHeThong
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.pContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNguoiDung,
            this.menuItemPhongBan,
            this.menuItemChucVu,
            this.menuItemNhanVien,
            this.menuItemLuong,
            this.menuItemThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemNguoiDung
            // 
            this.menuItemNguoiDung.Name = "menuItemNguoiDung";
            this.menuItemNguoiDung.Size = new System.Drawing.Size(84, 20);
            this.menuItemNguoiDung.Text = "Người Dùng";
            this.menuItemNguoiDung.Click += new System.EventHandler(this.menuItemNguoiDung_Click);
            // 
            // menuItemPhongBan
            // 
            this.menuItemPhongBan.Name = "menuItemPhongBan";
            this.menuItemPhongBan.Size = new System.Drawing.Size(77, 20);
            this.menuItemPhongBan.Text = "Phòng Ban";
            this.menuItemPhongBan.Click += new System.EventHandler(this.menuItemPhongBan_Click);
            // 
            // menuItemChucVu
            // 
            this.menuItemChucVu.Name = "menuItemChucVu";
            this.menuItemChucVu.Size = new System.Drawing.Size(64, 20);
            this.menuItemChucVu.Text = "Chức Vụ";
            this.menuItemChucVu.Click += new System.EventHandler(this.menuItemChucVu_Click);
            // 
            // menuItemNhanVien
            // 
            this.menuItemNhanVien.Name = "menuItemNhanVien";
            this.menuItemNhanVien.Size = new System.Drawing.Size(74, 20);
            this.menuItemNhanVien.Text = "Nhân Viên";
            this.menuItemNhanVien.Click += new System.EventHandler(this.menuItemNhanVien_Click);
            // 
            // menuItemLuong
            // 
            this.menuItemLuong.Name = "menuItemLuong";
            this.menuItemLuong.Size = new System.Drawing.Size(53, 20);
            this.menuItemLuong.Text = "Lương";
            this.menuItemLuong.Click += new System.EventHandler(this.menuItemLuong_Click);
            // 
            // menuItemThongKe
            // 
            this.menuItemThongKe.Name = "menuItemThongKe";
            this.menuItemThongKe.Size = new System.Drawing.Size(69, 20);
            this.menuItemThongKe.Text = "Thống Kê";
            this.menuItemThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContainer.Location = new System.Drawing.Point(12, 24);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(810, 475);
            this.pContainer.TabIndex = 1;
            // 
            // formHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống";
            this.Load += new System.EventHandler(this.formHeThong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem menuItemPhongBan;
        private System.Windows.Forms.ToolStripMenuItem menuItemChucVu;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuong;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.ToolStripMenuItem menuItemThongKe;
    }
}