using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class GuessNumberGUI : Form
    {
        #region VARIABLES
        Random randomNumber;
        int max,
            min,
            guessNumber;
        string defaultTextHint,
               defaultTextTitle;
        #endregion
        public GuessNumberGUI()
        {
            InitializeComponent();
            randomNumber = new Random();
            min = 1;
            max = 50;
            guessNumber = randomNumber.Next(min, max);

            defaultTextTitle = lblGuessNumber.Text;
            defaultTextHint = txtHint.Text;
        }
        #region EVENTS
        private void bttTry_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                int number = int.Parse(txtNumber.Text);

                if (number == guessNumber)
                {
                    ModifyLabel(
                        lblGuessNumber,
                        "YES, IS THE NUMBER! :)",
                        Color.Green);

                    lblRandomNumber.Text = guessNumber.ToString();
                    txtNumber.Clear();
                    MessageBox.Show("Congratulations! :D");
                    Reset();
                }
                else
                {
                    ModifyLabel(
                        lblGuessNumber,
                        "NO, ISN'T NUMBER! :(",
                        Color.Red);
                }
            }
            else
            {
                MessageBox.Show("¡Solamente se aceptan valores numericos!");
            }
        }
        private void bttHint_Click(object sender, EventArgs e)
        {
            bttHint.Enabled = false;
            StringBuilder sb = new StringBuilder();

            int rangeMin = (guessNumber - 5);
            int rangeMax = (guessNumber + 5);

            sb.Append("El numero que usted esta intentando adivinar esta entre los numeros ")
                .Append(rangeMin).Append(" y ").Append(rangeMax).Append("\n").Append("*Ademas es un numero ")
                .Append(IsEvenNumber(guessNumber) ? "par" : "impar");

            txtHint.Text = sb.ToString();
        }
        #endregion

        #region UTILS
        private void Reset()
        {
            ResetNumber();
            ResetHint();
            ResetTitle();
            RefreshNumber();
        }
        private void ResetHint()
        {
            ModifyButton(bttHint, "Hint?", Color.Red);
            txtHint.Text = defaultTextHint;
            bttHint.Enabled = true;
        }
        private void ResetNumber()
        {
            ModifyLabel(
                lblRandomNumber,
                "?");
        }

        private void ModifyButton(Button btt, string content, Color color)
        {
            btt.Text = content;
            btt.BackColor = color;
        }
        private void ModifyLabel(Label label, string content, Color color)
        {
            label.Text = content;
            label.ForeColor = color;
        }
        private void ModifyLabel(Label label, string content) => label.Text = content;
        private void ResetTitle()
        {
            ModifyLabel(
                lblGuessNumber,
                defaultTextTitle,
                Color.Blue
            );
        }
        private void RefreshNumber()
        {
            min = max;
            max += 50;
            guessNumber = randomNumber.Next(min, max);
        }
        private bool IsEvenNumber(int number) => number % 2 == 0;
        private bool CheckTextBox()
        {
            if (String.IsNullOrEmpty(txtNumber.Text)) return false;

            foreach (char number in txtNumber.Text)
            {
                if (!char.IsDigit(number))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion 
    }
}
