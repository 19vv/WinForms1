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
    public partial class AverageCalc : Form
    {
        public AverageCalc()
        {
            InitializeComponent();
        }

        private void lblValue2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(txtValue1.Text);
            double value2 = Convert.ToDouble(txtValue2.Text);
            double value3 = Convert.ToDouble(txtValue3.Text);

            double average = (value1 + value2 + value3) / 3;
            average = Math.Round(average,2);

            txtAverage.Text = average.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue1.Text = "0";
            txtValue2.Text = "0";
            txtValue3.Text = "0";
            txtAverage.Text = "0";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Adding some dummy comments
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
            // my second change
            // my school computer change, going to server
        }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void AverageCalc_Load(object sender, EventArgs e)
        {
            txtAverage.ReadOnly = true;
        }
    }
}
