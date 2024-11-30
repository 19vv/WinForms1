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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCurrencyConverter_Click(object sender, EventArgs e)
        {
            this.Hide();
            CC cc = new CC();
            cc.Show();
        }

        private void btnTempConverter_Click(object sender, EventArgs e)
        {
            this.Hide();
            TempConverter tempconverter = new TempConverter();
            tempconverter.Show();
        }

        private void btnAverageCalc_Click(object sender, EventArgs e)
        {
            this.Hide();
            AverageCalc averagecalc = new AverageCalc();
            averagecalc.Show();
        }
    }
}
