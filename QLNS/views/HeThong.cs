using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.views
{
    public partial class formHeThong : Form
    {
        public formHeThong()
        {
            InitializeComponent();
        }

        private void formHeThong_Load(object sender, EventArgs e)
        {
            this.loadFormNguoiDung();
        }

        private void loadFormNguoiDung()
        {
            formNguoiDung frmNguoiDung = new formNguoiDung() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmNguoiDung);
            frmNguoiDung.Show();
        }

        private void loadFormPhongBan()
        {
            formPhongBan frmPhongBan = new formPhongBan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmPhongBan);
            frmPhongBan.Show();
        }
        private void loadFormChucVu()
        {
            formChucVu frmChucVu = new formChucVu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmChucVu);
            frmChucVu.Show();
        }
        private void loadFormNhanVien()
        {
            formNhanVien frmNhanVien = new formNhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmNhanVien);
            frmNhanVien.Show();
        }
        private void loadFormLuong()
        {
            formLuong frmLuong = new formLuong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmLuong);
            frmLuong.Show();
        }

        private void loadFormThongKe()
        {
            formThongKe frmThongKe = new formThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmThongKe);
            frmThongKe.Show();
        }

        private void menuItemNguoiDung_Click(object sender, EventArgs e)
        {
            this.loadFormNguoiDung();
        }

        private void menuItemPhongBan_Click(object sender, EventArgs e)
        {
            this.loadFormPhongBan();
        }

        private void menuItemChucVu_Click(object sender, EventArgs e)
        {
            this.loadFormChucVu();
        }

        private void menuItemNhanVien_Click(object sender, EventArgs e)
        {
            this.loadFormNhanVien();
        }

        private void menuItemLuong_Click(object sender, EventArgs e)
        {
            this.loadFormLuong();
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            this.loadFormThongKe();
        }
    }
}
