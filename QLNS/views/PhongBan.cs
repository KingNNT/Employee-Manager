using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QLNS.models;

namespace QLNS.views
{
    public partial class formPhongBan : Form
    {
        public formPhongBan()
        {
            InitializeComponent();
        }

        string tableName = @"[QLNS].[dbo].[PhongBan]";
        DataSet ds = new DataSet();
        Database db = new Database();

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.updateData(ds, tableName);
            MessageBox.Show("Lưu Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.showData();
        }

        private void showData()
        {
            db.getData(ds, tableName);
            dtgrv.DataSource = null;
            dtgrv.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string colName = "TenPhong";

            db.findData(ds, tableName, colName, txtFind.Text);
            dtgrv.DataSource = null;
            dtgrv.DataSource = ds.Tables[tableName].DefaultView;

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void formPhongBan_Load(object sender, EventArgs e)
        {
            this.showData();
        }
    }
}
