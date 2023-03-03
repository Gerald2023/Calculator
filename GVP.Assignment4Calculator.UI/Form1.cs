using System;

namespace GVP.Assignment4Calculator.UI
{
    public partial class Form1 : Form
    {
        // calling the Calculator class

        Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click_event(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("Error: "))
            {
                txtDisplay.Clear();
            }
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
            }

            Button button = (Button)sender;
            txtDisplay.Text += button.Text;


        }
             


        private void operator_click(object sender, EventArgs e)
        {
            if (float.TryParse(txtDisplay.Text, out float d))
            {
                Button button = (Button)sender;
                calculator.Operation = button.Text;
                calculator.CurrentValue = d;
                txtDisplay.Clear();

            }
            else
            {
                MessageBox.Show("Please enter a number ");

            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

            try
            {
                if (float.TryParse(txtDisplay.Text, out float d))
                {
                    calculator.Result = d;
                    switch (calculator.Operation)
                    {
                        case "+":
                            calculator.Addition();

                            break;
                        case "-":
                            calculator.Substraction();

                            break;
                        case "*":

                            calculator.Multiplication();
                            break;

                        case "/":


                            calculator.Division();


                            break;
                    }

                    txtDisplay.Text = calculator.Result.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a number first");
                }
            }
            catch (DivideByZeroException ex)
            {

                txtDisplay.Text = "Error: " + ex.Message;

            }

        }


        private void single_operator(object sender, EventArgs e)
        {
            if (float.TryParse(txtDisplay.Text, out float d))
            {   Button button = (Button)sender;
                calculator.Operation = button.Text; // storing operator sign
                calculator.CurrentValue = d;

                switch (calculator.Operation)
                {
                    case "sqrt":

                        calculator.SquareRoot();
                        break;

                    case "1/X":

                        calculator.Reciprocal();
                        break;
                    case "+/-":
                        calculator.ChangeSign();
                        break;

                }
                txtDisplay.Text = calculator.Result.ToString();

            }
            else
            {
                MessageBox.Show("Please enter a number first");

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }
    }
}