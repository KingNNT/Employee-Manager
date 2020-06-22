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
    public partial class formChucVu : Form
    {
        public formChucVu()
        {
            InitializeComponent();
        }
        string tableName = @"[QLNS].[dbo].[ChucVu]";
        DataSet ds = new DataSet();
        Database db = new Database();

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.updateData(ds, tableName);
            MessageBox.Show("Lưu Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.showData();
        }


        private void formChucVu_Load(object sender, EventArgs e)
        {
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
            string colName = "TenChucVu";
            db.findData(ds, tableName, colName, txtFind.Text);
            dtgrv.DataSource = null;
            dtgrv.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.showData();
        }
    }
}
