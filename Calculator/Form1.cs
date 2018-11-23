using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string Display = "";
        float[] Tal = new float[10];
        float temporary;
        int[] Operationssymbol = new int[10];
        //+ = 1
        //- = 2
        //* = 3
        // / = 4

        //Tal[0] = 4500.0;
        int MaxAmountSymbols = 0, i = 0, k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != Display)
            {
                richTextBox1.Text = Display;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Display = Display + "0";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display = Display + "1";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display = Display + "2";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display = Display + "3";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display = Display + "4";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display = Display + "5";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display = Display + "6";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display = Display + "7";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display = Display + "8";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display = Display + "9";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(Display, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "+";
                Operationssymbol[k] = 1;
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                i++;
                k++;

            }
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Display = Display + ",";
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(Display, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "-";
                Operationssymbol[k] = 2;
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                i++;
                k++;
            }
        }

        private void Gånger_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(Display, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "*";
                Operationssymbol[k] = 3;
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                i++;
                k++;
            }
        }

        private void Dividerad_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(Display, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "/";
                Operationssymbol[k] = 4;
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                i++;
                k++;
                if (i >= 2)
                {
                    if (Operationssymbol[0] == 4)
                    {
                        temporary = Tal[1] / Tal[2];
                        Display = Convert.ToString(temporary);
                    }
                }
            }
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(Display, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "%";
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                i++;
            }
        }

        private void Tillbaks_Click(object sender, EventArgs e)
        {
            if (Display.Length > 0)
            {

                Display = Display.Remove(Display.Length - 1, 1);
                richTextBox1.Text = Display;
                if (MaxAmountSymbols == 1)
                {
                    MaxAmountSymbols = 0;
                }
            }
        }
    }
}