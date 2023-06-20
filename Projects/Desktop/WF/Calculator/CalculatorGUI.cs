using Calculator.Utils;

namespace Calculator
{
    public partial class CalculatorGUI : Form
    {
        double number,
               number2,
               result;

        char lastOperation;
        public CalculatorGUI()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            number = 0;
            number2 = 0;
            result = 0;
            lastOperation = 'N';
        }

        private void ResetDisplay() => txtDisplayCalculator.Text = "0";

        private void pressButton(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (result != 0)
            {
                ResetDisplay();
                result = 0;
            }

            if (txtDisplayCalculator.Text.Equals("0"))
            {
                if (!btn.Text.Equals("0"))
                {
                    txtDisplayCalculator.Text = btn.Text;
                }
            }
            else
            {
                txtDisplayCalculator.Text += btn.Text;
            }
        }

        private void PressDelete(object sender, EventArgs e)
        {
            if (txtDisplayCalculator.Text.Length > 0 && !txtDisplayCalculator.Text[0].Equals("0"))
            {
                var newDisplay = txtDisplayCalculator.Text.Substring(0, txtDisplayCalculator.Text.Length - 1);
                txtDisplayCalculator.Text = newDisplay;
            }

            if (txtDisplayCalculator.Text.Length == 0) ResetDisplay();
        }
        private void PressClear(object sender, EventArgs e)
        {
            ResetDisplay();
            InitializeVariables();
        }

        private void PressEqual(object sender, EventArgs e)
        {
            if (number != 0)
            {
                if (number2 == 0) number2 = int.Parse(txtDisplayCalculator.Text);

                switch (lastOperation)
                {
                    case '+':
                        result = Utils.Calculator.Sum(number, number2);
                        break;
                    case '-':
                        result = Utils.Calculator.Substract(number, number2);
                        break;
                    case '*':
                        result = Utils.Calculator.Multiplication(number, number2);
                        break;
                    case '/':
                        result = Utils.Calculator.Division(number, number2);
                        break;
                }

                txtDisplayCalculator.Text = result.ToString();
                number = result;
            }
        }
        private void PressSum(object sender, EventArgs e) => CheckAndDoOperation('+');
        private void PressSubstract(object sender, EventArgs e) => CheckAndDoOperation('-');
        private void PressMultiplication(object sender, EventArgs e) => CheckAndDoOperation('*');
        private void PressDivision(object sender, EventArgs e) => CheckAndDoOperation('/');

        private void CheckAndDoOperation(char operation)
        {
            if (txtDisplayCalculator.Text.Length > 0)
            {
                lastOperation = operation;
                if (number == 0)
                {
                    number = int.Parse(txtDisplayCalculator.Text);
                    ResetDisplay();
                }
                else
                {
                    number2 = int.Parse(txtDisplayCalculator.Text);
                }
            }


            if (number2 != 0)
            {
                result = DoOperation(lastOperation);
                txtDisplayCalculator.Text = result.ToString();
                number = result;
            }
        }
        private double DoOperation(char lastOperation){
            double resultOperation = 0;
            
            switch (lastOperation)
            {
                case '+':
                    resultOperation = Utils.Calculator.Sum(number, number2);
                    break;
                case '-':
                    resultOperation = Utils.Calculator.Substract(number, number2);
                    break;
                case '*':
                    resultOperation = Utils.Calculator.Multiplication(number, number2);
                    break;
                case '/':
                    resultOperation = Utils.Calculator.Division(number, number2);
                    break;
            }

            return resultOperation;
        }

    }
}