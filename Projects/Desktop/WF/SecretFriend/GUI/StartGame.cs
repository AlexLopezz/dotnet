using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretFriend.GUI
{
    public partial class StartGame : Form
    {
        SettingParticipants? settingParticipants;
        public StartGame()
        {
            InitializeComponent();
        }

        private void PressStartGame(object sender, EventArgs e)
        {
            this.Hide();
            settingParticipants = new SettingParticipants();
            settingParticipants.Show();
        }
    }
}
