using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //..determining

            const double VAT = 0.21;
            

            string inputSkm = txtInputStartKm.Text;
            double StartKm = double.Parse(inputSkm);

            string inputEkm = txtInputEndKm.Text;
            double EndKm = double.Parse(inputEkm);

            string inputP = txtInputPricePerKm.Text;
            double PricePerKm = double.Parse(inputP);
            
            //..calculating

            double vat = VAT * PricePerKm;

            double totalExclVAT = (EndKm - StartKm) * PricePerKm;
            vat = VAT * totalExclVAT;
            double totalInclVAT = totalExclVAT + vat;

            //..display

            lblPriceExclVAT.Text = totalExclVAT.ToString("0.00");
            lblPriceInclVAT.Text = totalInclVAT.ToString("0.00");
            lblVAT.Text = vat.ToString("0.00");

    

        
            
        }

        private void txtInputStartKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            //..erase 

            txtInputStartKm.Text = String.Empty;
            txtInputEndKm.Text = String.Empty;
            txtInputPricePerKm.Text = String.Empty;

            lblPriceExclVAT.Text = String.Empty;
            lblPriceInclVAT.Text = String.Empty;
            lblVAT.Text = String.Empty;
        }
    }
}
