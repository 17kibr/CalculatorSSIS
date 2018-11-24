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
        string HiddenDisplay = "";
        float[] Tal = new float[10];
        float temporary;
        int LastOperationssymbol = 0;
        //+ = 1
        //- = 2
        //* = 3
        // / = 4
        int MaxAmountSymbols = 0, i = 0;
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
            HiddenDisplay = HiddenDisplay + "0";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display = Display + "1";
            HiddenDisplay = HiddenDisplay + "1";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display = Display + "2";
            HiddenDisplay = HiddenDisplay + "2";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display = Display + "3";
            HiddenDisplay = HiddenDisplay + "3";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display = Display + "4";
            HiddenDisplay = HiddenDisplay + "4";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display = Display + "5";
            HiddenDisplay = HiddenDisplay + "5";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display = Display + "6";
            HiddenDisplay = HiddenDisplay + "6";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display = Display + "7";
            HiddenDisplay = HiddenDisplay + "7";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display = Display + "8";
            HiddenDisplay = HiddenDisplay + "8";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display = Display + "9";
            HiddenDisplay = HiddenDisplay + "9";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(HiddenDisplay, CultureInfo.InvariantCulture.NumberFormat);
                if (i == 0)
                {
                    Display = Display + "+";
                    richTextBox1.Text = Display;
                }
                LastOperationssymbol = 1;
                MaxAmountSymbols = 1;
                HiddenDisplay = "";
                StepCalculation();
                i++;
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
                Tal[i] = float.Parse(HiddenDisplay, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "-";
                LastOperationssymbol = 2;
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                HiddenDisplay = "";
                StepCalculation();
                i++;
            }
        }

        private void Gånger_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                    Tal[i] = float.Parse(HiddenDisplay, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "*";
                LastOperationssymbol = 3;
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                HiddenDisplay = "";
                StepCalculation();
                i++;
            }
        }

        private void Dividerad_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(HiddenDisplay, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "/";
                LastOperationssymbol = 4;
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                HiddenDisplay = "";
                StepCalculation();
                i++;
            }
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = float.Parse(HiddenDisplay, CultureInfo.InvariantCulture.NumberFormat);
                Display = Display + "%";
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                i++;
                HiddenDisplay = HiddenDisplay + "";
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
                else
                {
                    MaxAmountSymbols = 1;
                }
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {

        }

        private void StepCalculation()
        {
            switch (LastOperationssymbol)
            {
                case 1:
                    //plus
                    if (i >= 1)
                    {
                        temporary = Tal[i - 1] + Tal[i];
                        Math.Round(temporary, 2);
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Convert.ToString(temporary);
                        Display = Display + "+";
                        richTextBox1.Text = Display;
                        i--;
                        Tal[0] = temporary;
                        temporary = 0;
                    }
                    break;
                case 2:
                    //minus
                    if (i >= 1)
                    {
                        temporary = Tal[i - 1] - Tal[i];
                        Math.Round(temporary, 2);
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Convert.ToString(temporary);
                        Display = Display + "-";
                        richTextBox1.Text = Display;
                        i--;
                        Tal[0] = temporary;
                        temporary = 0;
                    }
                    break;
                case 3:
                    //Gånger
                    if (i >= 1)
                    {
                        temporary = Tal[i - 1] * Tal[i];
                        Math.Round(temporary, 2);
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Convert.ToString(temporary);
                        Display = Display + "*";
                        richTextBox1.Text = Display;
                        i--;
                        Tal[0] = temporary;
                    }
                    break;
                case 4:
                    //Dividerad
                    if (i >= 1)
                    {
                        temporary = Tal[i - 1] / Tal[i];
                        Math.Round(temporary, 2);
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Convert.ToString(temporary);
                        Display = Display + "/";
                        richTextBox1.Text = Display;
                        i--;
                        Tal[0] = temporary;
                        temporary = 0;
                    }
                    break;
                default:
                    //annat, borde alldrig förekomma
                    Console.WriteLine("None match.");
                    break;
            }
        } 
    }
}