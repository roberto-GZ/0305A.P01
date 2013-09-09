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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numero1, numero2;

        private void button1_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);

            MessageBox.Show(Convert.ToString(numero1 + numero2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);

            MessageBox.Show(Convert.ToString(numero1 * numero2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);

            MessageBox.Show(Convert.ToString(numero1 - numero2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);

            MessageBox.Show(Convert.ToString(numero1 / numero2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
