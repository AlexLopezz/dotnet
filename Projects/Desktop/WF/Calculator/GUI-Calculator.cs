using Calculator.Utils;

namespace Calculator
{
    public partial class CalculatorGUI : Form
    {
        #region VARIABLES   
        double number,
               number2,
               result;
        char? lastOperation;
        bool isNigthMode;

        Color black = Color.Black;
        Color white = Color.White;
        Color defaultColorDisplay,
              defaultColorButtons;

        List<Button> buttons;

        #endregion
        public CalculatorGUI()
        {
            InitializeComponent();
            InitializeVariables();
            InitializeButtons();
        }

        #region EVENTS
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

        private void InitializeButtons()
        {
            buttons = new List<Button>();

            buttons.Add(bttPoint);
            buttons.Add(btt0);
            buttons.Add(btt1);
            buttons.Add(btt2);
            buttons.Add(btt3);
            buttons.Add(btt4);
            buttons.Add(btt5);
            buttons.Add(btt6);
            buttons.Add(btt7);
            buttons.Add(btt8);
            buttons.Add(btt9);

            buttons.Add(bttSum);
            buttons.Add(bttSubstract);
            buttons.Add(bttMultiplication);
            buttons.Add(bttDivision);


        }
        private void PressDelete(object sender, EventArgs e)
        {
            if (txtDisplayCalculator.Text.Length > 0 && !txtDisplayCalculator.Text[0].Equals("0"))
            {
                var newDisplay = txtDisplayCalculator.Text.Substring(0, txtDisplayCalculator.Text.Length - 1);
                txtDisplayCalculator.Text = newDisplay;
                number = double.Parse(newDisplay);
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
                if (number2 == 0) number2 = double.Parse(txtDisplayCalculator.Text);

                result = DoOperation(lastOperation);
                txtDisplayCalculator.Text = result.ToString();
                number = result;
            }
        }
        private void PressSum(object sender, EventArgs e) => CheckAndDoOperation('+');
        private void PressSubstract(object sender, EventArgs e) => CheckAndDoOperation('-');
        private void PressMultiplication(object sender, EventArgs e) => CheckAndDoOperation('*');
        private void PressDivision(object sender, EventArgs e) => CheckAndDoOperation('/');

        #endregion

        #region UTILS
        private void InitializeVariables()
        {
            number = 0;
            number2 = 0;
            result = 0;
            lastOperation = null;
            isNigthMode = false;

            defaultColorDisplay = txtDisplayCalculator.BackColor;
            defaultColorButtons = bttNightMode.BackColor;
        }
        private void ResetDisplay() => txtDisplayCalculator.Text = "0";
        private void CheckAndDoOperation(char operation)
        {
            if (txtDisplayCalculator.Text.Length > 0)
            {
                if (lastOperation == null)
                {
                    lastOperation = operation;
                }
                else if (lastOperation != operation)
                {
                    lastOperation = operation;
                    ResetDisplay();
                    number2 = 0;
                    return;
                }

                if (number == 0)
                {
                    number = double.Parse(txtDisplayCalculator.Text);
                    result = number;
                    ResetDisplay();
                }
                else
                {
                    number2 = double.Parse(txtDisplayCalculator.Text);
                }
            }


            if (number2 != 0)
            {
                result = DoOperation(lastOperation);
                txtDisplayCalculator.Text = result.ToString();
                number = result;
            }
        }
        private double DoOperation(char? lastOperation)
        {
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
        #endregion

        private void ChangeToDefaultMode()
        {
            this.BackColor = defaultColorButtons;
            txtDisplayCalculator.BackColor = defaultColorDisplay;
            txtDisplayCalculator.ForeColor = black;
            foreach (var b in buttons)
            {
                b.BackColor = defaultColorButtons;
                b.ForeColor = black;
            }
            isNigthMode = false;
        }

        private void ChangeToNightMode()
        {
            this.BackColor = black;
            txtDisplayCalculator.BackColor = black;
            txtDisplayCalculator.ForeColor = white;

            foreach (var b in buttons)
            {
                b.BackColor = black;
                b.ForeColor = white;

            }
            isNigthMode = true;
        }

        private void PressNightMode(object sender, EventArgs e)
        {
            if (isNigthMode) ChangeToDefaultMode();
            else ChangeToNightMode();
        }
    }
}