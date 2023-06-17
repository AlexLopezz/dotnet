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
    public partial class SelectedPlayers : Form
    {
        private List<TextBox> _textBoxs;
        private Game _game;
        public SelectedPlayers()
        {
            InitializeComponent();
        }
        private void SelectedPlayers_Load(object sender, EventArgs e)
        {
            _game = new Game();
            this.CenterToScreen();
            LoadListTextBoxs();
        }

        private void LoadListTextBoxs()
        {
            _textBoxs = new List<TextBox>();
            _textBoxs.Add(txtPlayer1);
            _textBoxs.Add(txtPlayer2);
        }



        private void formClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void eventPlay(object sender, EventArgs e)
        {
            bool fillData = !_textBoxs.Any(X => string.IsNullOrEmpty(X.Text));

            if (!fillData)
            {
                MessageBox.Show(
                    "Para continuar debe completar los nombres de jugadores.",
                    "Complete los campos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                this.Hide();
                Thread.Sleep(1000);
                _game.Show();
            }
        }
    }
}
