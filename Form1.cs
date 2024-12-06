using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double Num1 = 0;
        Double Num2 = 0;
        char Operation = '+';

        
        private void BTNOne_MouseHover(object sender, EventArgs e)
        {
            BTNOne.BackColor = Color.White;
            BTNOne.ForeColor = Color.Black;
        }

        private void BTNOne_MouseLeave(object sender, EventArgs e)
        {
            BTNOne.BackColor = Color.Gray;
            BTNOne.ForeColor = Color.White;
        }

        private void BTNTwo_MouseHover(object sender, EventArgs e)
        {
            BTNTwo.BackColor = Color.White;
            BTNTwo.ForeColor = Color.Black;
        }

        private void BTNTwo_MouseLeave(object sender, EventArgs e)
        {
            BTNTwo.BackColor = Color.Gray;
            BTNTwo.ForeColor = Color.White;
        }
        private void BTNThree_MouseHover(object sender, EventArgs e)
        {
            BTNThree.BackColor = Color.White;
            BTNThree.ForeColor = Color.Black;
        }

        private void BTNThree_MouseLeave(object sender, EventArgs e)
        {
            BTNThree.BackColor = Color.Gray;
            BTNThree.ForeColor = Color.White;
        }
        private void BTNFour_MouseHover(object sender, EventArgs e)
        {
            BTNFour.BackColor = Color.White;
            BTNFour.ForeColor = Color.Black;
        }

        private void BTNFour_MouseLeave(object sender, EventArgs e)
        {
            BTNFour.BackColor = Color.Gray;
            BTNFour.ForeColor = Color.White;
        }
        private void BTNFive_MouseHover(object sender, EventArgs e)
        {
            BTNFive.BackColor = Color.White;
            BTNFive.ForeColor = Color.Black;
        }

        private void BTNFive_MouseLeave(object sender, EventArgs e)
        {
            BTNFive.BackColor = Color.Gray;
            BTNFive.ForeColor = Color.White;
        }
        private void BTNSix_MouseHover(object sender, EventArgs e)
        {
            BTNSix.BackColor = Color.White;
            BTNSix.ForeColor = Color.Black;
        }

        private void BTNSix_MouseLeave(object sender, EventArgs e)
        {
            BTNSix.BackColor = Color.Gray;
            BTNSix.ForeColor = Color.White;
        }
        private void BTNSeven_MouseHover(object sender, EventArgs e)
        {
            BTNSeven.BackColor = Color.White;
            BTNSeven.ForeColor = Color.Black;
        }

        private void BTNSeven_MouseLeave(object sender, EventArgs e)
        {
            BTNSeven.BackColor = Color.Gray;
            BTNSeven.ForeColor = Color.White;
        }
        private void BTNEight_MouseHover(object sender, EventArgs e)
        {
            BTNEight.BackColor = Color.White;
            BTNEight.ForeColor = Color.Black;
        }

        private void BTNEight_MouseLeave(object sender, EventArgs e)
        {
            BTNEight.BackColor = Color.Gray;
            BTNEight.ForeColor = Color.White;
        }

        private void BTNNine_MouseHover(object sender, EventArgs e)
        {
            BTNNine.BackColor = Color.White;
            BTNNine.ForeColor = Color.Black;
        }

        private void BTNNine_MouseLeave(object sender, EventArgs e)
        {
            BTNNine.BackColor = Color.Gray;
            BTNNine.ForeColor = Color.White;
        }
        private void BTNZero_MouseHover(object sender, EventArgs e)
        {
            BTNZero.BackColor = Color.White;
            BTNZero.ForeColor = Color.Black;
        }

        private void BTNZero_MouseLeave(object sender, EventArgs e)
        {
            BTNZero.BackColor = Color.Gray;
            BTNZero.ForeColor = Color.White;
        }
        private void BTNPoint_MouseHover(object sender, EventArgs e)
        {
            BTNPoint.BackColor = Color.White;
            BTNPoint.ForeColor = Color.Black;
        }

        private void BTNPoint_MouseLeave(object sender, EventArgs e)
        {
            BTNPoint.BackColor = Color.Gray;
            BTNPoint.ForeColor = Color.White;
        }



        private void BTNOne_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "1";
            else
                TXBEtnterNumbers.Text += "1";
        }

        private void BTNTwo_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "2";
            else
                TXBEtnterNumbers.Text += "2";
        }

        private void BTNThree_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "3";
            else
                TXBEtnterNumbers.Text += "3";
        }

        private void BTNFour_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "4";
            else
                TXBEtnterNumbers.Text += "4";
        }

        private void BTNFive_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "5";
            else
                TXBEtnterNumbers.Text += "5";
        }

        private void BTNSix_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "6";
            else
                TXBEtnterNumbers.Text += "6";
        }

        private void BTNSeven_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "7";
            else
                TXBEtnterNumbers.Text += "7";
        }
        
        private void BTNEight_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "8";
            else
                TXBEtnterNumbers.Text += "8";
        }

        private void BTNNine_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "9";
            else
                TXBEtnterNumbers.Text += "9";
        }

        private void BTNZero_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0")
                TXBEtnterNumbers.Text = "0";
            else
                TXBEtnterNumbers.Text += "0";
        }
        private void BTNPoint_Click(object sender, EventArgs e)
        {
            if (TXBEtnterNumbers.Text == "0" || TXBEtnterNumbers.Text == "")
                TXBEtnterNumbers.Text = "0.";
            else
                TXBEtnterNumbers.Text += ".";
        }



        private void BTNAdd_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TXBEtnterNumbers.Text);
            TXBEtnterNumbers.Text = "0";
            Operation = '+';
        }

        private void BTNSub_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TXBEtnterNumbers.Text);
            TXBEtnterNumbers.Text = "0";
            Operation = '-';
        }

        private void BTNMul_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TXBEtnterNumbers.Text);
            TXBEtnterNumbers.Text = "0";
            Operation = '*';
        }

        private void BTNDiv_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TXBEtnterNumbers.Text);
            TXBEtnterNumbers.Text = "0";
            Operation = '/';
        }
        private void BTNMod_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TXBEtnterNumbers.Text);
            TXBEtnterNumbers.Text = "0";
            Operation = '%';
        }
        private void BTNSQR_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TXBEtnterNumbers.Text);
            TXBEtnterNumbers.Text = "0";
            Operation = 'S';
        }
        private void BTNEqual_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case '+':
                    {
                        Num2 = Convert.ToDouble(TXBEtnterNumbers.Text);
                        Double Result = Num1 + Num2;
                        TXBEtnterNumbers.Text = Result.ToString();
                        break;
                    }
                case '-':
                    {
                        Num2 = Convert.ToDouble(TXBEtnterNumbers.Text);
                        Double Result = Num1 - Num2;
                        TXBEtnterNumbers.Text = Result.ToString();
                        break;
                    }
                case '*':
                    {
                        Num2 = Convert.ToDouble(TXBEtnterNumbers.Text);
                        Double Result = Num1 * Num2;
                        TXBEtnterNumbers.Text = Result.ToString();
                        break;
                    }
                case '/':
                    {
                        Num2 = Convert.ToDouble(TXBEtnterNumbers.Text);
                        Double Result = Num1 / Num2;
                        TXBEtnterNumbers.Text = Result.ToString();
                        break;
                    }
                case '%':
                    {
                        Num2 = Convert.ToDouble(TXBEtnterNumbers.Text);
                        Double Result = Num1 % Num2;
                        TXBEtnterNumbers.Text = Result.ToString();
                        break;
                    }
                case 'S':
                    {
                        Double Result = Math.Sqrt(Num1);
                        TXBEtnterNumbers.Text = Result.ToString();
                        break;
                    }
                default:
                    TXBEtnterNumbers.Text = "0";
                    break;
            }

        }



        private void BTNDelete_Click(object sender, EventArgs e)
        {
            TXBEtnterNumbers.Text = "0";
        }

        private void BTNBackSpace_Click(object sender, EventArgs e)
        {
            TXBEtnterNumbers.Text = TXBEtnterNumbers.Text.Substring(0, TXBEtnterNumbers.TextLength - 1);
        }




    }
}
