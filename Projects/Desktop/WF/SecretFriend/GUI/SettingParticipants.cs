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
        #region VARIABLES

        string[] participants; 
        bool ExistParticipant;
  

        #endregion
        public SettingParticipants()
        {
            InitializeComponent();
            cboCountParticipants.SelectedIndex = 0;
        }

        #region EVENTS
        /// <summary>
        /// Este evento verificara si la lista y arreglo esta cargado de
        /// participantes y luego mostrara el formulario de opciones del Home.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void bttReset_Click(object sender, EventArgs e) => ResetGame();
        private void bttReady_Click(object sender, EventArgs e)
        {
            Home home = new Home(FillSecretFriend(participants));
            home.Show();
            this.Hide();
        }
        #endregion


        #region UTILS
        /// <summary>
        /// Este metodo es el encargado de rellenar la lista de participantes
        /// con sus respectivos amigos invisibles.
        /// </summary>
        /// <param name="participants"></param>
        /// <returns></returns>
        Dictionary<string, string> FillSecretFriend(string[] participants)
        {
            
            bool isSelectedParticipant; //Servira para verificar si se selecciono o no un participante.
            string[] selectedParticipants = new string[participants.Length]; //Servira para almacenar aquellos participantes seleccionados.
            var secretFriend = new Dictionary<string, string>(); //Servira para rellenar un diccionario con participantes y su amigo invisible
            var random = new Random(); //Para elegir cualquier participante de la lista de participantes.


            for (int i = 0; i < participants.Length; i++)
            {
                
                do
                {
                    //Obtenemos en una variable un participante random de la lista.
                    string potentialParticipant = participants[random.Next(0, participants.Length)]; 

                    //Si ese participante no es el mismo que el participante actual ni tampoco es parte de la lista de participantes seleccionados:
                    if (!participants[i].Equals(potentialParticipant) &&
                        !IsSelectedParticipant(selectedParticipants, potentialParticipant))
                    {
                        //Vamos a agregar a la lista de participantes seleccionados el participante agregado al diccionario, para no tener repetidos.
                        selectedParticipants[i] = potentialParticipant;
                        //Luego, procedemos a agregar a el diccionario como clave: el participante y como valor, el participante random seleccionado anteriormente.
                        secretFriend.Add(participants[i], selectedParticipants[i]);

                        //Cambiamos el valor a true, para salir del bucle de verificacion.
                        isSelectedParticipant = true;
                    }
                    else
                    {
                        //Si no se cumple con la condicion propuesta, volvemos a iterar... Hasta que toque un participante que cumpla con la condicion.
                        isSelectedParticipant = false; 
                    }
                } while (!isSelectedParticipant);
            }

            //Por ultimo, vamos a retornar el diccionario con los respectivos participantes y amigos invisibles.
            return secretFriend;
        }
        /// <summary>
        /// Este metodo cambiara los valores de configuracion, a la normalidad.
        /// </summary>
        void ResetGame()
        {
            bttOK.Enabled = true;
            bttReset.Enabled = true;
            cboCountParticipants.SelectedIndex = 0;
            cboCountParticipants.Enabled = true;
            ResetParticipants();
            lboParticipants.Items.Clear();
        }
        /// <summary>
        /// Este metodo modificara todos los valores del arreglo y lo dejara vacio.
        /// </summary>
        void ResetParticipants()
        {
            for (int i = 0; i < participants.Length; i++)
            {
                participants[i] = string.Empty;
            }
        }

        /// <summary>
        /// Este metodo verificara si existe un participante con el nombre ingresado.
        /// </summary>
        /// <param name="participant">Nombre</param>
        /// <returns></returns>
        bool CheckIfParticipantExist(String participant) => participants.Contains(participant);
        /// <summary>
        ///  Este metodo verificara si existe en la lista de participantes
        ///  seleccionados, el nombre del participante
        /// </summary>
        /// <param name="selectedParticipants"></param>
        /// <param name="nombreParticipante"></param>
        /// <returns></returns>
        bool IsSelectedParticipant(String[] selectedParticipants, String nombreParticipante) => selectedParticipants.Any(p => p != null && p.Equals(nombreParticipante));
        #endregion
    }
}
