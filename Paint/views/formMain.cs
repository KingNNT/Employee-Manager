using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.views
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lbResult.Text = "";
        }

        private void control (int n)
        {
            lbResult.Text = "";

            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    lbResult.Text += "  ";
                }
                for (int j = 0; j < (i - 1)*2 + 1; j++)
                {
                    lbResult.Text += " *";
                }
                lbResult.Text += "\n";
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    lbResult.Text += "  ";
                }
                for (int j = 0; j < (i - 1) * 2 + 1; j++)
                {
                    lbResult.Text += " *";
                }
                lbResult.Text += "\n";
            }


        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                lbResult.Text = "";
                return;
            }
            else
            {
                int n = 0;
                try
                {
                    n = Int32.Parse(txtInput.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (n >= 13)
                {
                    MessageBox.Show("Hiển Thị Có Thể Vượt Quá Form", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                this.control(n);
            }
        }
    }
}
