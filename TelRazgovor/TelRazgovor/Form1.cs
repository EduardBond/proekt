using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelRazgovor
{
    public partial class TelRazgovor : Form
    {
        public TelRazgovor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBDlitRazg_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && num != 44)
            {
                e.Handled = true;
            }
        }

        private void txtBNumNed_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && num != 44)
            {
                e.Handled = true;
            }
        }

        private void txtBDlitRazg_TextChanged(object sender, EventArgs e)
        {
            if (txtBDlitRazg.Text != " " & txtBNumNed.Text != " ") btnEquals.Enabled = true;
        }

        private void txtBNumNed_TextChanged(object sender, EventArgs e)
        {
            if (txtBDlitRazg.Text != " " & txtBNumNed.Text != " ") btnEquals.Enabled = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int y;
            double z, x;
            x = Convert.ToDouble(txtBDlitRazg.Text);
            y = Convert.ToInt32(txtBNumNed.Text);
            if (y >= 1 && y <= 7)
            {
                //lblDlitRazg.Visible = false;
                if (y == 6 || y == 7)
                {
                    z = (2.5 - 0.2 * 2.5) * x;
                }
                else z = 2.5 * x;
                MessageBox.Show("Разговор длился " + x + " минут, разговор был в " + y + " день недели. Стоимость разговора состовляет " + z + " рублей", "Стоимость разговора", MessageBoxButtons.OK);
            }
            else lblDlitRazg.Visible = true;
        }
    }
}
