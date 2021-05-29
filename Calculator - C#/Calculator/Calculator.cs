using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        String operation = "";
        double firstNum, secondNum;
        public Calculator()
        {
            InitializeComponent();
        }
        private void buttonC_Clicked(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            String f, s;
            s = Convert.ToString(secondNum);
            f = Convert.ToString(firstNum);

            s = "";
            f = "";
        }

        private void operationalFunction(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstNum + secondNum); break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstNum - secondNum); break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstNum * secondNum); break;
                case "/":
                    txtDisplay.Text = Convert.ToString(firstNum / secondNum); break;
                default:
                    break;
            }
        }

        private void numericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += b.Text;
                }
            }
            else
            {
                txtDisplay.Text += b.Text;
            }

        }
    }
}
