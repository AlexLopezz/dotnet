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
        ListParticipant listParticipant;
        CheckSecretFriend checkSecretFriend;
        SaveFileDialog saveFileDialog;
        Dictionary<string, string> participants;

        public Home(Dictionary<string, string> participants)
        {
            InitializeComponent();
            this.participants = participants;
            listParticipant = new ListParticipant(participants);
            checkSecretFriend = new CheckSecretFriend(participants);
            saveFileDialog = new SaveFileDialog();
        }

        private void PressListButton(object sender, EventArgs e) => listParticipant.Show();
        private void bttSecretFriend_Click(object sender, EventArgs e) => checkSecretFriend.Show();
        private void button4_Click(object sender, EventArgs e) => Application.Exit();
        private void PressSaveButton(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Archivos de texto(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try{
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    foreach (var sf in participants)
                    {
                        streamWriter.WriteLine("Participante: "+sf.Key+ " | Amigo invisible: "+sf.Value);
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

    }
}
