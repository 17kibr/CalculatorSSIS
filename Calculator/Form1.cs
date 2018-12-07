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
        string LabelDisplay = "";
        decimal[] Tal = new decimal[10];
        decimal temporary;
        int LastOperationssymbol = 0, Operationssymbol = 0;
        bool TillbaksPressed = false;
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
            label1.Text = LabelDisplay;

        }
        private void button10_Click(object sender, EventArgs e)
        {
            Display = Display + "0";
            HiddenDisplay = HiddenDisplay + "0";
            LabelDisplay = LabelDisplay + "0";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display = Display + "1";
            HiddenDisplay = HiddenDisplay + "1";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display = Display + "2";
            HiddenDisplay = HiddenDisplay + "2";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display = Display + "3";
            HiddenDisplay = HiddenDisplay + "3";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display = Display + "4";
            HiddenDisplay = HiddenDisplay + "4";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display = Display + "5";
            HiddenDisplay = HiddenDisplay + "5";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display = Display + "6";
            HiddenDisplay = HiddenDisplay + "6";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display = Display + "7";
            HiddenDisplay = HiddenDisplay + "7";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display = Display + "8";
            HiddenDisplay = HiddenDisplay + "8";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display = Display + "9";
            HiddenDisplay = HiddenDisplay + "9";
            richTextBox1.Text = Display;
            MaxAmountSymbols = 0;
            TillbaksPressed = false;
            LabelDisplay = LabelDisplay + "9";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                if (TillbaksPressed == false)
                {
                    Tal[i] = decimal.Parse(HiddenDisplay, CultureInfo.InvariantCulture);
                }
                Display = Display + "-";
                if (Operationssymbol == 0)
                {
                    Operationssymbol = 1;
                }
                else
                {
                    LastOperationssymbol = 1;
                }
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                LabelDisplay = LabelDisplay + "+";
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
                LabelDisplay = LabelDisplay + ",";
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                if (TillbaksPressed == false)
                {
                    Tal[i] = decimal.Parse(HiddenDisplay, CultureInfo.InvariantCulture);
                }
                Display = Display + "-";
                if (Operationssymbol == 0)
                {
                    Operationssymbol = 2;
                }
                else
                {
                    LastOperationssymbol = 2;
                }
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                LabelDisplay = LabelDisplay + "-";
                HiddenDisplay = "";
                StepCalculation();
                i++;
            }
        }

        private void Gånger_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                if (TillbaksPressed == false)
                {
                    Tal[i] = decimal.Parse(HiddenDisplay, CultureInfo.InvariantCulture);
                }
                Display = Display + "*";
                if (Operationssymbol == 0)
                {
                    Operationssymbol = 3;
                }
                else
                {
                    LastOperationssymbol = 3;
                }
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                LabelDisplay = LabelDisplay + "*";
                HiddenDisplay = "";
                StepCalculation();
                i++;
            }
        }

        private void Dividerad_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                if (TillbaksPressed == false)
                {
                    Tal[i] = decimal.Parse(HiddenDisplay, CultureInfo.InvariantCulture);
                }
                Display = Display + "/";
                if (Operationssymbol == 0)
                {
                    Operationssymbol = 4;
                }
                else
                {
                    LastOperationssymbol = 4;
                }
                richTextBox1.Text = Display;
                MaxAmountSymbols = 1;
                LabelDisplay = LabelDisplay + "/";
                HiddenDisplay = "";
                StepCalculation();
                i++;
            }
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            if (MaxAmountSymbols == 0)
            {
                Tal[i] = decimal.Parse(HiddenDisplay, CultureInfo.InvariantCulture.NumberFormat);
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

                TillbaksPressed = true;
                Display = Display.Remove(Display.Length - 1, 1);
                richTextBox1.Text = Display;
                if (MaxAmountSymbols == 1)
                {
                    MaxAmountSymbols = 0;
                    Tal[1] = 0;
                    if (i == 1)
                    {
                        i--;
                    }
                }
                else
                {
                    MaxAmountSymbols = 1;
                }
                if (HiddenDisplay.Length > 0 && MaxAmountSymbols == 0)
                {
                    HiddenDisplay = HiddenDisplay.Remove(Display.Length - 1, 1);
                }
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {

        }

        private void LikaMed_Click(object sender, EventArgs e)
        {
            if (Tal[1] != 0)
            {
                switch (Operationssymbol)
                {
                    case 1:
                        temporary = Tal[0] + Tal[1];
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Display;
                        HiddenDisplay = "";
                        LabelDisplay = LabelDisplay + "=";
                        label1.Text = LabelDisplay;
                        Display = "";
                        LabelDisplay = "";
                        Operationssymbol = 0;
                        LastOperationssymbol = 0;
                        TillbaksPressed = false;
                        Tal[0] = 0;
                        Tal[1] = 0;
                        break;
                    case 2:
                        temporary = Tal[0] - Tal[1];
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Display;
                        HiddenDisplay = "";
                        LabelDisplay = LabelDisplay + "=";
                        label1.Text = LabelDisplay;
                        Display = "";
                        LabelDisplay = "";
                        Operationssymbol = 0;
                        LastOperationssymbol = 0;
                        TillbaksPressed = false;
                        Tal[0] = 0;
                        Tal[1] = 0;
                        break;
                    case 3:
                        temporary = Tal[0] * Tal[1];
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Display;
                        HiddenDisplay = "";
                        LabelDisplay = LabelDisplay + "=";
                        label1.Text = LabelDisplay;
                        Display = "";
                        LabelDisplay = "";
                        Operationssymbol = 0;
                        LastOperationssymbol = 0;
                        TillbaksPressed = false;
                        Tal[0] = 0;
                        Tal[1] = 0;
                        break;
                    case 4:
                        temporary = Tal[0] / Tal[1];
                        Display = Convert.ToString(temporary);
                        richTextBox1.Text = Display;
                        HiddenDisplay = "";
                        LabelDisplay = LabelDisplay + "=";
                        label1.Text = LabelDisplay;
                        Display = "";
                        LabelDisplay = "";
                        Operationssymbol = 0;
                        LastOperationssymbol = 0;
                        TillbaksPressed = false;
                        Tal[0] = 0;
                        Tal[1] = 0;
                        break;
                    default:
                        richTextBox1.Text = "ERROR";
                        break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StepCalculation()
        {
            switch (Operationssymbol)
            {
                case 1:
                    //plus
                    if (i >= 1)
                    {
                        if (Operationssymbol == LastOperationssymbol || LastOperationssymbol == 0)
                        {
                            if (Operationssymbol == LastOperationssymbol)
                            {
                                temporary = Tal[i - 1] + Tal[i];
                                Display = Convert.ToString(temporary);
                                richTextBox1.Text = Convert.ToString(temporary);
                                Display = Display + "+";
                                richTextBox1.Text = Display;
                                i--;
                                Tal[0] = temporary;
                                temporary = 0;
                            }
                        }
                        else
                        {
                            SwitchCalculation();
                        }
                    }
                    break;
                case 2:
                    //minus
                    if (i >= 1)
                    {
                        if (Operationssymbol == LastOperationssymbol || LastOperationssymbol == 0)
                        {
                            if (Operationssymbol == LastOperationssymbol)
                            {
                                temporary = Tal[i - 1] - Tal[i];
                                Display = Convert.ToString(temporary);
                                richTextBox1.Text = Convert.ToString(temporary);
                                Display = Display + "-";
                                richTextBox1.Text = Display;
                                i--;
                                Tal[0] = temporary;
                                temporary = 0;
                            }
                        }
                        else
                        {
                            SwitchCalculation();
                        }
                    }
                    break;
                case 3:
                    //Gånger
                    if (i >= 1)
                    {
                        if (Operationssymbol == LastOperationssymbol || LastOperationssymbol == 0)
                        {
                            if (Operationssymbol == LastOperationssymbol)
                            {
                                temporary = Tal[i - 1] * Tal[i];
                                Display = Convert.ToString(temporary);
                                richTextBox1.Text = Convert.ToString(temporary);
                                Display = Display + "*";
                                richTextBox1.Text = Display;
                                i--;
                                Tal[0] = temporary;
                                temporary = 0;
                            }
                        }
                        else
                        {
                            SwitchCalculation();
                        }
                    }
                    break;
                case 4:
                    //Dividerad
                    if (i >= 1)
                    {
                        if (Operationssymbol == LastOperationssymbol || LastOperationssymbol == 0)
                        {
                            if (Operationssymbol == LastOperationssymbol)
                            {
                                temporary = Tal[i - 1] / Tal[i];
                                Display = Convert.ToString(temporary);
                                richTextBox1.Text = Convert.ToString(temporary);
                                Display = Display + "/";
                                richTextBox1.Text = Display;
                                i--;
                                Tal[0] = temporary;
                                temporary = 0;
                            }
                        }
                        else
                        {
                            SwitchCalculation();
                        }
                    }
                    break;
                default:
                    //annat, borde alldrig förekomma
                    Console.WriteLine("None match.");
                    break;
            }
        } 
        private void SwitchCalculation()
        {
            switch (LastOperationssymbol)
            {
                case 1:
                    //plus
                    switch (Operationssymbol)
                    {
                        case 1:
                            //ingenting borde hända
                            break;
                        case 2:
                            temporary = Tal[i - 1] - Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "+";
                            Operationssymbol = 1;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 3:
                            temporary = Tal[i - 1] * Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "+";
                            Operationssymbol = 1;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 4:
                            temporary = Tal[i - 1] / Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "+";
                            Operationssymbol = 1;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                    }
                    break;
                case 2:
                    //minus
                    switch (Operationssymbol)
                    {
                        case 1:
                            temporary = Tal[i - 1] + Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "-";
                            Operationssymbol = 2;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 2:
                            //ingenting borde hända
                            break;
                        case 3:
                            temporary = Tal[i - 1] * Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "-";
                            Operationssymbol = 2;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 4:
                            temporary = Tal[i - 1] / Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "-";
                            Operationssymbol = 2;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                    }
                    break;
                case 3:
                    //Gånger
                    switch (Operationssymbol)
                    {
                        case 1:
                            temporary = Tal[i - 1] + Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "*";
                            Operationssymbol = 3;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 2:
                            temporary = Tal[i - 1] - Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "*";
                            Operationssymbol = 3;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 3:
                            //ingenting borde hända
                            break;
                        case 4:
                            temporary = Tal[i - 1] / Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "*";
                            Operationssymbol = 3;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                    }
                    break;
                case 4:
                    //Dividerad
                    switch (Operationssymbol)
                    {
                        case 1:
                            temporary = Tal[i - 1] + Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "/";
                            Operationssymbol = 4;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 2:
                            temporary = Tal[i - 1] - Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "/";
                            Operationssymbol = 4;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 3:
                            temporary = Tal[i - 1] * Tal[i];
                            Tal[0] = temporary;
                            Display = Convert.ToString(temporary);
                            richTextBox1.Text = Convert.ToString(temporary);
                            temporary = 0;
                            Display = Display + "/";
                            Operationssymbol = 4;
                            LastOperationssymbol = 0;
                            richTextBox1.Text = Display;
                            i--;
                            break;
                        case 4:
                            //ingenting borde hända
                            break;
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