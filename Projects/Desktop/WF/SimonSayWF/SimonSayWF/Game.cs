using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSayWF
{
    public partial class Game : Form
    {
        int sequence = 0, pointsPlayer = 0;
        string textDefaultButton;
        Random random;
        Color backColorDefault;
        List<int> sequenceSimonSay;
        bool speakSimon;

        public Game()
        {
            InitializeComponent();
            backColorDefault = panelGame.BackColor;
            sequenceSimonSay = new List<int>();
            random = new Random();
            speakSimon = false;
            textDefaultButton = bttSimonSay.Text;
        }

        private void ChangeToNewGame()
        {
            bttSimonSay.BackColor = Color.Green;
            bttSimonSay.Text = "NEW GAME";
        }
        private void ChangeToSimonSay()
        {
            bttSimonSay.BackColor = Color.Red;
            bttSimonSay.Text = textDefaultButton;
        }
        private void CheckPressButton(int bttValue)
        {
            if (speakSimon || sequenceSimonSay.Count == 0) return;

            if (sequenceSimonSay[sequence] == bttValue)
            {
                sequence++;
                pointsPlayer++;
            }
            else
            {
                sequence = 0;
                pointsPlayer = 0;
                MessageBox.Show($"Perdiste. Tu score es de: {pointsPlayer}");
                ChangeToNewGame();
                sequenceSimonSay.Clear();
                return;
            }

            if (sequence >= sequenceSimonSay.Count)
            {
                sequence = 0;
                sequenceSimonSay.Add(random.Next(0, 4));
                Thread.Sleep(100);
                new Thread(StartGame).Start();
            }
            lblScore.Text = sequenceSimonSay.Count.ToString();
        }
        private void IluminateButton(Button btt)
        {
            btt.BackColor = Color.White;
            Thread.Sleep(500);
            btt.BackColor = backColorDefault;
        }
        private void StartGame()
        {
            Thread.Sleep(200);
            speakSimon = true;

            foreach (int sequence in sequenceSimonSay)
            {
                switch (sequence)
                {
                    case 0:
                        IluminateButton(bttBurguer_0);
                        break;
                    case 1:
                        IluminateButton(bttEmpanada_1);
                        break;
                    case 2:
                        IluminateButton(bttPizza_2);
                        break;
                    case 3:
                        IluminateButton(bttNoodle_3);
                        break;
                }
                Thread.Sleep(200);
            }
            speakSimon = false;
        }
        private void bttSimonSay_Click(object sender, EventArgs e)
        {
            if (bttSimonSay.Text != textDefaultButton) ChangeToSimonSay();
            ClickStartGame();
        }

        private void ClickStartGame()
        {
            sequenceSimonSay.Add(random.Next(0, 4));
            new Thread(StartGame).Start();
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button bttPressed = (Button)sender;
            var valueBttPressed = bttPressed.Name[bttPressed.Name.Length - 1].ToString();
            CheckPressButton(int.Parse(valueBttPressed));
        }

        private void PressButton(object sender, MouseEventArgs e)
        {
            var bttPressed = (Button)sender;
            bttPressed.BackColor = Color.White;
        }

        private void StopPressButton(object sender, MouseEventArgs e)
        {
            var bttPressed = (Button)sender;
            bttPressed.BackColor = backColorDefault;
        }
    }
}
