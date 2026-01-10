using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_to_letter_grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {

            double numgrade;
            string letgrade;

            numgrade = double.Parse(textBoxNumGrade.Text);

            if ((numgrade > 89.9)&&(numgrade <= 100))
            {
                letgrade = "A";
                textBoxLetGrade.Text = letgrade;
            }
            else if ((numgrade > 79.9)&&(numgrade <= 89.9))
            {
                letgrade = "B";
                textBoxLetGrade.Text = letgrade;
            }
            else if ((numgrade > 69.9)&&(numgrade <= 79.9))
            {
                letgrade = "C";
                textBoxLetGrade.Text = letgrade;
            }
            else if ((numgrade > 59.9)&&(numgrade <= 69.9))
            {
                letgrade = "D";
                textBoxLetGrade.Text = letgrade;
            }
            else if ((numgrade <= 59.9)&&(numgrade >= 0))
            {
                letgrade = "F";
                textBoxLetGrade.Text = letgrade;
            }
            else
            {
                textBoxLetGrade.Text = "INVALID";
            }
        }

        private void buttonSWCase_Click(object sender, EventArgs e)
        {

            double numbergrade = textBoxNumGrade.Text;
            double score = numbergrade / 10;
            int scr = Convert.ToInt32(score);
            string lettergrade;
            bool valid = double.TryParse(textBoxNumGrade.Text, out numbergrade);
            
            

            if (valid)
            {



                if ((numbergrade <= 100) && (numbergrade >= 0))
                {


                    switch (scr)
                    {
                        case (10):
                        case (9):
                            lettergrade = "A";
                            textBoxLetGrade.Text = lettergrade;
                            break;
                        case (8):
                            lettergrade = "B";
                            textBoxLetGrade.Text = lettergrade;
                            break;
                        case (7):
                            lettergrade = "C";
                            textBoxLetGrade.Text = lettergrade;
                            break;
                        case (6):
                            lettergrade = "D";
                            textBoxLetGrade.Text = lettergrade;
                            break;
                        default:
                            lettergrade = "F";
                            textBoxLetGrade.Text = lettergrade;
                            break;
                    }
                }
            }
            else
                textBoxLetGrade.Text = "INVALID";

        }
    }
}
