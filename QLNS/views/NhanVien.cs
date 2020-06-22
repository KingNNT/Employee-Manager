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
using System.Data;

namespace QLNS.views
{
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
        }
        string tableName = @"[QLNS].[dbo].[NhanVien]";
        DataSet ds = new DataSet();
        Database db = new Database();
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.updateData(ds, tableName);
            MessageBox.Show("Lưu Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.showData();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            this.showData();
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbPhongBan.Items.Add(dt.Rows[i]["MaPhong"]);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbChucVu.Items.Add(dt.Rows[i]["MaChucVu"]);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string colName1 = "MaPhong";
            string colName2 = "MaChucVu";
            db.findData(ds, tableName, colName1, colName2, cbPhongBan.Text, cbChucVu.Text);
            dtgrv.DataSource = null;
            dtgrv.DataSource = ds.Tables[tableName].DefaultView;
        }
        private void showData()
        {
            db.getData(ds, tableName);
            dtgrv.DataSource = null;
            dtgrv.DataSource = ds.Tables[tableName].DefaultView;
        }
    }
}
