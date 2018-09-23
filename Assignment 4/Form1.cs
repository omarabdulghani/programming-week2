using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
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

        private void btnCalculateVAT_Click(object sender, EventArgs e)
        {
            //..determining
        
            const double VAT = 0.21;
            string input = txtEnterPrice.Text;
            double price = double.Parse(input);
            
            //..calculating

            double vat = VAT * price;
            double amount = price + vat;

            //..display

            lblPrice.Text = price.ToString("0.00");
            lblTotal.Text = amount.ToString("0.00");
            lblVAT.Text = vat.ToString("0.00");




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

   
            

      




        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            
          
            

            
        }

        private void lblVAT_Click(object sender, EventArgs e)
        {
            


        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
