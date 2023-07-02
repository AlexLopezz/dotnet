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
        #region VARIABLES
        SettingParticipants? settingParticipants;
        #endregion
        public StartGame()
        {
            InitializeComponent();
        }

        #region EVENTS
        /// <summary>
        /// Este evento mostrara el formulario de configuracion
        /// y cerrara este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PressStartGame(object sender, EventArgs e)
        {
            this.Hide();
            settingParticipants = new SettingParticipants();
            settingParticipants.Show();
        }
        #endregion
    }
}
