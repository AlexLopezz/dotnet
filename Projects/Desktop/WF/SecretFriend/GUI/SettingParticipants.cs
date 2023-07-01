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
    public partial class SettingParticipants : Form
    {
        string[] participants;
        bool ExistParticipant;
        Home home;
        public SettingParticipants()
        {
            InitializeComponent();
            cboCountParticipants.SelectedIndex = 0;
        }

        private void PressOK(object sender, EventArgs e)
        {
            if (cboCountParticipants.SelectedIndex != 0)
            {
                //Vamos a crear un arreglo fijo con la cantidad de participantes seleccionado del combo box.
                participants = new string[int.Parse(cboCountParticipants.Text)];

                //Vamos a realizar una iteracion para completar los campos del arreglo con los nombres de los participantes.
                for (int i = 0; i < participants.Length; i++)
                {
                    int countTry = 1;
                    string participant;
                    //Validacion del participante: Para que no existan participantes con el mismo nombre.
                    do
                    {
                        participant = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Ingrese por favor nombre del Participante({(i + 1)})",
                        "Rellenando planilla de participantes",
                        "Fulanito Perez");

                        if (CheckIfParticipantExist(participant))
                        {
                            MessageBox.Show(
                                "No debe existir participantes con nombres iguales.",
                                "No se pudo agregar participante.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            ExistParticipant = true;
                        }
                        else if (string.IsNullOrEmpty(participant))
                        {
                            if (countTry > 0)
                            {
                                MessageBox.Show(
                                    "Por favor, ingrese un nombre para el participante.",
                                    "No se pudo agregar participante.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                countTry--;
                            }
                            else
                            {
                                var result = MessageBox.Show(
                                                "Vimos que no ingreso ningun nombre. ¿Desea salir?",
                                                "No se pudo agregar participante.",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);

                                if (result == DialogResult.OK)
                                {
                                    ResetGame();
                                    return;
                                }
                            }
                            ExistParticipant = true;
                        }
                        else
                        {

                            ExistParticipant = false;
                        }

                    } while (ExistParticipant);

                    participants[i] = participant;
                    lboParticipants.Items.Add(participant);
                }
                bttOK.Enabled = false;
                cboCountParticipants.Enabled = false;
            }
            else
            {
                MessageBox.Show("Esta vacio.");
            }
        }

        private void bttReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        void ResetGame()
        {
            bttOK.Enabled = true;
            bttReset.Enabled = true;
            cboCountParticipants.SelectedIndex = 0;
            cboCountParticipants.Enabled = true;
            ResetParticipants();
            lboParticipants.Items.Clear();
        }

        void ResetParticipants()
        {
            for (int i = 0; i < participants.Length; i++)
            {
                participants[i] = string.Empty;
            }
        }
        bool CheckIfParticipantExist(String participant) => participants.Contains(participant);

        private void bttReady_Click(object sender, EventArgs e)
        {
            home = new Home(FillSecretFriend(participants));
            home.Show();
            this.Hide();
        }

        bool IsSelectedParticipant(String[] selectedParticipants, String nombreParticipante) => selectedParticipants.Any(p => p != null && p.Equals(nombreParticipante));
        Dictionary<string, string> FillSecretFriend(string[] participants)
        {
            bool isSelectedParticipant;
            string[] selectedParticipants = new string[participants.Length];
            var random = new Random();

            Dictionary<string, string> secretFriend = new Dictionary<string, string>();

            for (int i = 0; i < participants.Length; i++)
            {
                do
                {
                    string potentialParticipant = participants[random.Next(0, participants.Length)];

                    if (!participants[i].Equals(potentialParticipant) &&
                        !IsSelectedParticipant(selectedParticipants, potentialParticipant))
                    {

                        selectedParticipants[i] = potentialParticipant;
                        secretFriend.Add(participants[i], selectedParticipants[i]);
                        isSelectedParticipant = true;
                    }
                    else
                    {
                        isSelectedParticipant = false;
                    }
                } while (!isSelectedParticipant);
            }
            return secretFriend;
        }
    }
}
