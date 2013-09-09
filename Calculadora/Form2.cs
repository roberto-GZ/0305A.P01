using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

            
              
      

        private void button2_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtGrados.Text);
            double gradosF;
            gradosF = celsius * 9 / 5 + 32;
            lblRes.Text = "ºF " + gradosF.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtGrados.Text);
            double kelvin;
            kelvin = 273.15 + celsius;
            lblRes.Text = "ºK " + kelvin.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double kelvin = Convert.ToDouble(txtGrados.Text);
            double gradosCelsius;
            gradosCelsius = kelvin - 273.15;
            lblRes.Text = "ºC " + gradosCelsius.ToString();
        }

        private void FaC_Click(object sender, EventArgs e)
        {
            double gradosF = Convert.ToDouble(txtGrados.Text);
            double gradosCelsius;
            gradosCelsius = (gradosF - 32) * 5 / 9;
            lblRes.Text = "ºC " + gradosCelsius.ToString();
        }
                     

     }
}

