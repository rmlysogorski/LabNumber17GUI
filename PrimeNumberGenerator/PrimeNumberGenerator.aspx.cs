using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimeNumberGenerator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PrimeButton_Click(object sender, EventArgs e)
        {
            int textboxInput;

            if (TextBox1.Text == string.Empty)
            {
                PrimeNumberLabel.Text = "Please enter a number!";
            }
            else if (int.Parse(TextBox1.Text) <= 0)
            {
                PrimeNumberLabel.Text = "Please enter a positive number greater than 0!";
            }
            else
            {
                textboxInput = int.Parse(TextBox1.Text);
                int prime = 2;
                int count = 1;
                bool isPrime;
                for (int i = 3; count < textboxInput; i += 2)
                {
                    isPrime = true;
                    for (int j = 3; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        prime = i;
                        count++;
                    }
                }
                PrimeNumberLabel.Text = $"The number {textboxInput.ToString()} prime number is {prime}.";
            }

            PrimeNumberLabel.Visible = true;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}