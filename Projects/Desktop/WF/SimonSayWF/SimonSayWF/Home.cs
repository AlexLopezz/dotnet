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
        private SelectedPlayers _formSelectedPlayers;
        public Home()
        {
            InitializeComponent();
            _formSelectedPlayers = new SelectedPlayers();
        }

        private void eventStart(object sender, EventArgs e)
        {
            _formSelectedPlayers.Show();
            this.Hide();
        }
        private void eventExit(object sender, EventArgs e) => Application.Exit();



    }
}
