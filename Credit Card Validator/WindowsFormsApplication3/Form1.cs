using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Procedure to return the sum of the even and odd numbers of the reversed card number
        // as per the necessary rules
        private int reversedNumSum(string num)
        {
            string reverseCardNum = "";
            int oddSum = 0;
            int evenSum = 0;

            for (int i = num.Length - 1; i >= 0; i = i-1)
            {
                reverseCardNum += num.Substring(i,1);
            }

            for (int x = 1; x <= reverseCardNum.Length; x = x + 2)
            {
                oddSum = oddSum + Convert.ToInt32(reverseCardNum.Substring(x - 1, 1));
            }

            for (int x = 2; x <= reverseCardNum.Length; x = x + 2)
            {
                string y;
                y = Convert.ToString(Convert.ToInt32(reverseCardNum.Substring(x - 1, 1)) * 2);

                if (y.Length == 1)
                {
                    evenSum = evenSum + Convert.ToInt32(y);
                }
                else if (y.Length == 2)
                {
                    evenSum = evenSum + Convert.ToInt32(y.Substring(0, 1))
                        + Convert.ToInt32(y.Substring(1, 1));
                }

            }

            return (oddSum + evenSum);
        }
        
        // Procedure to return card type using the card number
        private string creditCardType(string cardNum)
        {
            string cardType = "";

            if (cardNum.Substring(0, 1) == "4"
                && cardNum.Length == 16
                && reversedNumSum(cardNum) % 10 == 0)
            {
                cardType = "VISA card is";
            }

            else if (Convert.ToInt32(cardNum.Substring(0, 2)) >= 51
                && Convert.ToInt32(cardNum.Substring(0, 2)) <= 55
                && cardNum.Length == 16
                && reversedNumSum(cardNum) % 10 == 0)
            {
                cardType = "Master Card (Diners Club for you Americans) is";
            }

            else if (cardNum.Substring(0, 2) == "34"
                || cardNum.Substring(0, 2) == "37"
                && cardNum.Length == 15
                && reversedNumSum(cardNum) % 10 == 0)
            {
                cardType = "American Express is";
            }

            else if (cardNum.Substring(0, 4) == "6011" 
                    && cardNum.Length == 16
                    && reversedNumSum(cardNum) % 10 == 0)
            {
                cardType = "Discover is";
            }

            else if (cardNum.Substring(0, 2) == "36" 
                    && cardNum.Length == 14
                    && reversedNumSum(cardNum) % 10 == 0)
            {
                cardType = "Diners Club (outside U.S. and Canada) is";
            }

            else
            {
                cardType = "is not";
            }

            return cardType;

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            {
                string cardNum = creditCardNumInput.Text;

                if (cardNum != "")
                {
                    label1.Text = "This " + creditCardType(cardNum) + " valid";
                }
                else
                    label1.Text = "Please enter credit card number";
            }
        }
    }
}
