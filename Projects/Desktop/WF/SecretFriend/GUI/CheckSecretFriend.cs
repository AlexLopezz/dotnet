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
    public partial class CheckSecretFriend : Form
    {
        #region VARIABLES
        //Obtenemos la lista de participantes como una variable global, para poder utilizarla a gusto.
        Dictionary<string, string> participants;
        #endregion
        public CheckSecretFriend(Dictionary<string, string> participants)
        {
            InitializeComponent();
            this.participants = participants;
        }

        #region EVENTS
        /// <summary>
        /// Este evento mostrara el amigo invisible que le toco
        /// al participante quien ingreso su nombre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttCheck_Click(object sender, EventArgs e)
        {
            //Si en el diccionario se encuentra el nombre como clave, entonces... Procedemos a obtener su valor y mostrarlo al usuario.
            if (participants.Keys.Contains(txtName.Text))
            {
                txtSecretFriend.Text = participants.GetValueOrDefault(txtName.Text);
            }
            else //Sino... Mostramos por pantalla un mensaje de error, notificando el problema sucedido.
            {
                MessageBox.Show(
                    "Verifique el nombre ingresado, no lo encontramos en nuestra lista de participantes.",
                    "No se encontro el participante ingresado.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        #endregion
    }
}
