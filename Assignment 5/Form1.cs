using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateAvrg_Click(object sender, EventArgs e)
        {
            //..determining

            string inputNrOne = txtNumberOne.Text;
            int nrOne = int.Parse(inputNrOne);

            string inputNrTwo = txtNumberTwo.Text;
            int nrTwo = int.Parse(inputNrTwo);

            string inputNrThree = txtNumberThree.Text;
            int nrThree = int.Parse(inputNrThree);

            //..calculating

            double result = (nrOne + nrTwo + nrThree) / 3.0;

            //..display

            lblResult.Text = result.ToString("0.000");
            
           

        }
    }
}
