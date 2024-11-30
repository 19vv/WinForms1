using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Puzzles_2__PP2_
{
    public partial class CC : Form
    {
        public CC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double gbpValue = 0.0;
            double usdValue = 0.0;
            gbpValue = Convert.ToDouble(txtGBP.Text);
            usdValue = Convert.ToDouble(txtUSD.Text);
            
            if (usdValue == 0.0 && gbpValue == 0.0)
            {
                MessageBox.Show("Please enter a value for currency.");
            }
            else if (usdValue != 0.0 && gbpValue != 0.0)
            {
                MessageBox.Show("Please enter only one value to be converted.");
            }
            else if (gbpValue == 0.0)
            {
                gbpValue = Math.Round((usdValue / 1.26),2);
                txtGBP.Text = Convert.ToString(gbpValue);
            }
            else if (usdValue == 0.0)
            {
                usdValue = Math.Round((gbpValue * 1.26),2);
                txtUSD.Text = usdValue.ToString();
            }
        }

        private void txtGBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGBP.Clear();
            txtUSD.Clear();
            txtGBP.Text = "0";
            txtUSD.Text = "0";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
