using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.models
{
    class Database
    {
        private string str_conn = @"Data Source=localhost;Initial Catalog=QLNS;Integrated Security=True";


        public bool login(string txtUsr, string txtPwd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                conn.Open();
                string query = @"SELECT* FROM [QLNS].[dbo].[NguoiDung] WHERE TaiKhoan LIKE @usr AND MatKhau LIKE @pwd";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("usr", txtUsr));
                command.Parameters.Add(new SqlParameter("pwd", txtPwd));

                SqlDataReader data = command.ExecuteReader();
                if (data.Read() == true)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void getData(DataSet ds, string tableName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT* FROM " + tableName;
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                ds.Reset();
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateData(DataSet ds, string tableName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT* FROM " + tableName;
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                SqlCommandBuilder cmdbd = new SqlCommandBuilder(da);

                da.Update(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findData(DataSet ds, string tableName, string colName, string txtFind)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT* FROM " + tableName + @"WHERE " + colName + @" LIKE '" + txtFind + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                ds.Reset();
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findData(DataSet ds, string tableName, string colName1, string colName2, string txtFind1, string txtFind2)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT* FROM " + tableName + @"WHERE " + colName1 + @" LIKE '" + txtFind1 + "' AND " + colName2 + @" Like '" + txtFind2 + "' ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                ds.Reset();
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}