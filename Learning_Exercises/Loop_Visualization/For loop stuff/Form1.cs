using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_loop_stuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOutput1.Items.Clear();
            for (int i = 1; i < 20; i++)
            {
                listOutput1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            listOutput2.Items.Clear();
            for (int i = 1; i < 101; i++)
            {
                x += i;
                listOutput2.Items.Add("i= " + i.ToString() + ", sum= " + x.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 1;
            listOutput3.Items.Clear();
            for (int i = 1; i < 17; i++)
            {
                sum = sum * i;
                listOutput3.Items.Add("i = " + i.ToString() + ", factorial = " + sum.ToString());
            }
        }
    }
}
