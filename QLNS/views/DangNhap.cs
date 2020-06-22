using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.models;

namespace QLNS.views
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.login(txtUserName.Text, txtPassWord.Text))
            {
                this.Hide();
                formHeThong fHT = new formHeThong();
                fHT.Show();
                MessageBox.Show("Đăng Nhập Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
