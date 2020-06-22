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
    public partial class formLuong : Form
    {
        public formLuong()
        {
            InitializeComponent();
        }
        string tableName = @"[QLNS].[dbo].[Luong]";
        DataSet ds = new DataSet();
        Database db = new Database();

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.updateData(ds, tableName);
            MessageBox.Show("Lưu Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.showData();
        }

        private void formLuong_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void showData()
        {
            db.getData(ds, tableName);
            dtgrv.DataSource = null;
            dtgrv.DataSource = ds.Tables[tableName].DefaultView;
        }
    }
}
