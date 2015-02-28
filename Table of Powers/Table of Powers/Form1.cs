using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table_of_Powers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int userNum = Convert.ToInt32(inputBox.Text);
            powerTable.Items.Add("N" + "\t" + "N^2" + "\t"+ "N^3");

            for (int counter = 1; counter <= userNum; counter++)
            {
                powerTable.Items.Add(counter + "\t" + Math.Pow(counter,2) + "\t" + Math.Pow(counter,3));
            }


        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            powerTable.Items.Clear();
        }
    }
}
