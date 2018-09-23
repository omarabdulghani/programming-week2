using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..determining

            const int MINUTE = 60;
            const int HOUR = 3600;

            string input = txtNrOfSeconds.Text;
            int Seconds = int.Parse(input);

            //..calculating

            int nrOfHours = (Seconds / HOUR);

            int nrOfMinutes = (Seconds - (nrOfHours * HOUR)) / MINUTE;

            int nrOfSeconds = (Seconds - (nrOfHours * HOUR) - (nrOfMinutes * MINUTE));

            //..display

            lblResultHours.Text = nrOfHours.ToString("00");
            lblResultMinutes.Text = nrOfMinutes.ToString("00");
            lblResultSeconds.Text = nrOfSeconds.ToString("00");

        }

        private void txtNrOfSeconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultHours_Click(object sender, EventArgs e)
        {

        }
    }
}
