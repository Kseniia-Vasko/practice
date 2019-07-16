using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calk_oop
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            double result = firstArgument + secondArgument;
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Calk(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "Add":
                    result = firstArgument + secondArgument;
                    break;
                case "Subtraction":
                    result = firstArgument - secondArgument;
                    break;
                case "Multiplication":
                    result = firstArgument * secondArgument;
                    break;
                case "Divide":
                    result = firstArgument / secondArgument;
                    break;
                default:
                    throw new Exception("Unknown operation");
            }
            label1.Text = result.ToString();
        }
    }
}
