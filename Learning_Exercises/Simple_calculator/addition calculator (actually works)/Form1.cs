using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addition_calculator__actually_works_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            sum = num1 + num2;
            textBox3.Text = Convert.ToString(sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            sum = num1 - num2;
            textBox3.Text = Convert.ToString(sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            sum = num1 * num2;
            textBox3.Text = Convert.ToString(sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            sum = num1 / num2;
            textBox3.Text = Convert.ToString(sum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
