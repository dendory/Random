using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            radioButton1.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            radioButton1.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            radioButton2.Select();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            radioButton2.Select();
        }

        private String Number2String(int number, bool isCaps)
        {

            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (radioButton1.Checked == true)
            {
                if (min.Value < max.Value)
                {
                    int randomNumber = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value)+1);
                    result.Text = randomNumber.ToString();
                }
                else result.Text = "Min must be lesser than Max.";
            }
            else
            {
                string str = "";
                for (int c = 1; c < chars.Value+1; c++)
                {
                    int randomNumber = random.Next(0, 61);
                    if (randomNumber > 9 && randomNumber < 36) str += Number2String(randomNumber - 9, false);
                    else if (randomNumber > 35) str += Number2String(randomNumber - 35, true);
                    else str += randomNumber.ToString();
                }
                result.Text = str;
            }
        }
    }
}
