using System;
using System.Windows.Forms;
using calk_oop.OneArgumentFunctions;
using calk_oop.TwoArgumentFunctions;

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


        private void Calk(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                double secondArgument = Convert.ToDouble(textBox2.Text);
                double result;
                var Calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
                result = Calculator.Calculate(firstArgument, secondArgument);

                label1.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка " + exc.Message);
            }
        }
        private void OneArgumentCalk(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);

                double result;
                var Calculator = OneArgumentsFactory.CreateCalculator(((Button) sender).Name);
                result = Calculator.Calculate(firstArgument);

                label1.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка " + exc.Message);
            }
        }
    }
}
