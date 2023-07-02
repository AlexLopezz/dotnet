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
    public partial class ListParticipant : Form
    {
        public ListParticipant(Dictionary<string, string> participants)
        {
            InitializeComponent();
            LoadDgvParticipant(participants);
        }
        #region UTILS
        /// <summary>
        /// Este metodo cargara el datagridview con la lista de 
        /// participantes y sus respectivos amigos invisibles.
        /// </summary>
        /// <param name="participants"></param>
        void LoadDgvParticipant(Dictionary<string, string> participants)
        {
            //Cargando los datos de manera manual, con un datatable:
            DataTable dt = new DataTable();
            //Agregamos las columnas correspondientes.
            dt.Columns.Add("Participante");
            dt.Columns.Add("Amigo invisible");

            //Por cada participante, vamos rellenando las filas con los datos correspondientes:
            foreach (var p in participants)
            {
                var row = dt.NewRow();
                row["Participante"] = p.Key; //Para la fila de participantes, iria la llave
                row["Amigo invisible"] = p.Value; //Para la fila de amigo invisible, iria el valor de la llave actual.

                //Por ultimo, agregamos la nueva fila a el datatable:
                dt.Rows.Add(row);
            }

            //Cuando estee todo configurado, indicamos el datasource del datagrid con el datatable manualmente cargado.
            dgvParticipants.DataSource = dt;
        }
        #endregion

    }
}
