using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2;
            resultLabel.Text = result.ToString();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;
            resultLabel.Text = result.ToString();
        }

        private void multiButton_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;
            resultLabel.Text = result.ToString();
        }

        private void diviButton_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 / num2;
            resultLabel.Text = result.ToString();
        }
    }
}
