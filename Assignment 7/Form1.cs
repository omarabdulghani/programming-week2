using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //..determining

            const double TSHIRTS = 30.00;
            const double JEANS = 100.00;
            const double VAT = 0.21;

            string inputTshirts = txtinputTshirts.Text;
            double Tshirts = double.Parse(inputTshirts);

            string inputJeans = txtinputJeans.Text;
            double Jeans = double.Parse(inputJeans);

            //..calculating 

            double totalpriceTshirts = Tshirts * TSHIRTS;
            double totalpriceJeans = Jeans * JEANS;

            double total = totalpriceTshirts + totalpriceJeans;
            double vat = total * VAT;
            double totalprice = total + vat;

            //..display

            lblTotalPrice.Text = totalprice.ToString("0.00");
            lblVAT.Text = vat.ToString("0.00");
            lblPrice.Text = total.ToString("0.00");
            lblDate.Text = DateTime.Now.ToString("HH:mm dd-MM-yyyy");



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
