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
    public partial class Home : Form
    {
        Game game;
        public Home()
        {
            InitializeComponent();
            game = new Game();
        }

        private void eventStart(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }
        private void eventExit(object sender, EventArgs e) => Application.Exit();



    }
}
