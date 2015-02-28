using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //dim vars
            double dollarsToConvert = Convert.ToDouble(dollarToConvertTB.Text);
            string currtype = currencyBox.Text.ToUpper();
            double amount;

            //logic to decide which currency is entered and to convert said currency
            if (currtype == "YEN")
            {
                amount = dollarsToConvert * 75;
            }
            else if (currtype=="EURO")
            {
                amount=dollarsToConvert*.74;
            }
            else if (currtype=="PESO")
            {
                amount = dollarsToConvert * 14;
            }
            else
            {
                amount = 0;
                MessageBox.Show("Please enter a valid currency", "Invalid Currency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //output result to results label
            resultsLabel.Text = Convert.ToString(amount);
        }
    }
}
