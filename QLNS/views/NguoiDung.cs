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
using System.Data.SqlClient;

namespace QLNS.views
{
    public partial class formNguoiDung : Form
    {
        public formNguoiDung()
        {
            InitializeComponent();
        }

        string tableName = @"[QLNS].[dbo].[NguoiDung]";
        DataSet ds = new DataSet();
        Database db = new Database();
        private void formNguoiDung_Load(object sender, EventArgs e)
        {
            this.showData();
        }

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

        private void dtgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
