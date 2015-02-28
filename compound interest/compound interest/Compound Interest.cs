using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compound_interest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBTN_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(principalTB.Text);
            double rate;
            const int years = 10;
            string output;
            double amount;
            double rateInt;
            output = "Rate(%)" + "\t" + "\t" + "Amount after 10 years"+"\r\n";

            for (int counter = 5; counter < 11; counter++)
            {
                rateInt = Convert.ToDouble(counter);
                rate = rateInt / 100;
                amount = principal * Math.Pow((1 + rate), years);
                output += string.Format("{0:D}", counter) + "\t" + "\t" + string.Format("{0:C}", amount)+"\r\n";
                resultsTB.Text = output;

            }


        }
    }
}
