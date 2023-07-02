using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SecretFriend.GUI
{
    public partial class Home : Form
    {
        #region VARIABLES
        SaveFileDialog saveFileDialog;
        Dictionary<string, string> participants;
        #endregion
        public Home(Dictionary<string, string> fillParticipants)
        {
            InitializeComponent();
            this.participants = fillParticipants;
            saveFileDialog = new SaveFileDialog();
        }

        #region EVENTS
        /// <summary>
        /// Este evento mostrara el formulario de la lista de participantes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PressListButton(object sender, EventArgs e)
        {
            ListParticipant listParticipant = new ListParticipant(participants);
            listParticipant.Show();
        }
        /// <summary>
        /// Este evento mostrara el formulario de verificar por el nombre del participante
        /// el amigo invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttSecretFriend_Click(object sender, EventArgs e)
        {
            CheckSecretFriend checkSecretFriend = new CheckSecretFriend(this.participants);
            checkSecretFriend.Show();
        }
        /// <summary>
        /// Este evento mostrara un cuadro de dialogo de guardado, donde el usuario debera
        /// indicar la ruta donde desea guardar en .txt la lista de participantes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PressSaveButton(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Archivos de texto(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    foreach (var sf in participants)
                    {
                        streamWriter.WriteLine("Participante: " + sf.Key + " | Amigo invisible: " + sf.Value);
                    }
                    streamWriter.Close();

                    MessageBox.Show(
                        "¡Archivo guardado con exito!",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bttSave.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Disculpe, ocurrio un error al querer guardar.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }


            }
        }
        #endregion
        /// <summary>
        /// Este evento finalizara la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}
