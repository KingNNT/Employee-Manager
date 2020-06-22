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
    public partial class formThongKe : Form
    {
        public formThongKe()
        {
            InitializeComponent();
        }
        string tableName = @"[QLNS].[dbo].[Luong]";
        DataSet ds = new DataSet();
        Database db = new Database();
        private void formThongKe_Load(object sender, EventArgs e)
        {
            db.getData(ds, tableName);
            DataTable dt = ds.Tables[0];
            //cbMaNhanVien.Items.Add(dt.Rows[0]["MaNhanVien"]);
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                //bool check = false;
                //for (int j = 0; j < cbMaNhanVien.Items.Count; j++)
                //{
                //    if (dt.Rows[i]["MaNhanVien"] == cbMaNhanVien.Items[j])
                //    {
                //        check = true;
                //        break;
                //    }
                //}
                //if (check == false)
                //{
                //    cbMaNhanVien.Items.Add(dt.Rows[i]["MaNhanVien"]);
                //}

                cbMaNhanVien.Items.Add(dt.Rows[i]["MaNhanVien"]);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNam.Items.Add(dt.Rows[i]["Nam"]);
            }
        }
        private void showData()
        {
            db.findData(ds, tableName, "MaNhanVien", "Nam", cbMaNhanVien.Text, cbNam.Text);
            dtgrv.DataSource = null;
            dtgrv.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.showData();
        }
    }
}
