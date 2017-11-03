using System;
using System.Windows;


namespace MathsOperators
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)addition.IsChecked)
                {
                    addValues();
                }
                else if ((bool)subtraction.IsChecked)
                {
                    subtractValues();
                }
                else if ((bool)multiplication.IsChecked)
                {
                    multiplyValues();
                }
                else if ((bool)division.IsChecked)
                {
                    divideValues();
                }
                else if ((bool)remainder.IsChecked)
                {
                    remainderValues();
                }
                else if ((bool)sin.IsChecked)
                {
                    sinValues();
                }
                else if ((bool)cos.IsChecked)
                {
                    cosValues();
                }
                else if ((bool)module.IsChecked)
                {
                    moduleValues();
                }
            }
            catch (Exception caught)
            {
                expression.Text = "";
                result.Text = caught.Message;
            }
        }

        private void addValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Add rhs to lhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " + " + rhsOperand.Text;
            outcome = lhs + rhs;
            result.Text = outcome.ToString();
        }

        private void subtractValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Subtract rhs from lhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " - " + rhsOperand.Text;
            outcome = lhs - rhs;
            result.Text = outcome.ToString();
        }

        private void multiplyValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Multiply lhs by rhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " * " + rhsOperand.Text;
            outcome = lhs * rhs;
            result.Text = outcome.ToString();
        }

        private void divideValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Divide lhs by rhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " / " + rhsOperand.Text;
            if (rhs == 0)
            {
                result.Text = "No result";
            }
            else
            {
                outcome = lhs / rhs;
                result.Text = outcome.ToString();
            }
            
        }

        private void remainderValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Work out the remainder after dividing lhs by rhs and store the result in outcome

            expression.Text = lhsOperand.Text + " % " + rhsOperand.Text;
            outcome = lhs % rhs;
            result.Text = outcome.ToString();
        }

        private void sinValues()
        {
            double lhs = double.Parse(lhsOperand.Text);
            //int rhs = int.Parse(rhsOperand.Text);
            double outcome = 0;
            // TODO: Work out the remainder after dividing lhs by rhs and store the result in outcome

            rhsOperand.Text = "";
            expression.Text = "sin( " + lhsOperand.Text + " ) = ";
            outcome = Math.Round(Math.Sin(lhs),2);
            result.Text = outcome.ToString();
        }

        private void cosValues()
        {
            double lhs = double.Parse(lhsOperand.Text);
            //int rhs = int.Parse(rhsOperand.Text);
            double outcome = 0;
            // TODO: Work out the remainder after dividing lhs by rhs and store the result in outcome

            rhsOperand.Text = "";
            expression.Text = "cos( " + lhsOperand.Text + " ) = ";
            outcome = Math.Round(Math.Cos(lhs), 2);
            result.Text = outcome.ToString();
        }

        private void moduleValues()
        {
            double lhs = double.Parse(lhsOperand.Text);
            //int rhs = int.Parse(rhsOperand.Text);
            double outcome = 0;
            // TODO: Work out the remainder after dividing lhs by rhs and store the result in outcome

            rhsOperand.Text = "";
            expression.Text = "| " + lhsOperand.Text + " | = ";
            outcome = Math.Abs(lhs);
            result.Text = outcome.ToString();
        }

        private void quitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
