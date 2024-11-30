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
    public partial class TempConverter : Form
    {
        public TempConverter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double farenheit = 0.0;
            double celcius = 0.0;
            farenheit = Convert.ToDouble(txtFarenheit.Text);
            celcius = Convert.ToDouble(txtCelcius.Text);    
            if (farenheit == 0.0 && celcius == 0.0)
            {
                MessageBox.Show("Please enter a value for temperature.");
            }
            else if (farenheit != 0.0 && celcius != 0.0)
            {
                MessageBox.Show("Please enter only one value to be converted.");
            }
            else if (farenheit == 0.0)
            {
                farenheit = Math.Round(((celcius * 9 / 5) + 32),2);
                txtFarenheit.Text = Convert.ToString(farenheit);
            }
            else if (celcius  == 0.0)
            {
                celcius = Math.Round(((farenheit - 32) * 5 / 9),2);
                txtCelcius.Text = Convert.ToString(celcius);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCelcius.Clear();
            txtFarenheit.Clear();
            txtCelcius.Text = "0";
            txtFarenheit.Text = "0";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
