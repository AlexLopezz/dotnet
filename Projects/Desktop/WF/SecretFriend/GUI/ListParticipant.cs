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

        void LoadDgvParticipant(Dictionary<string, string> participants)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Participante");
            dt.Columns.Add("Amigo invisible");

            foreach (var p in participants)
            {
                var row = dt.NewRow();
                row["Participante"] = p.Key;
                row["Amigo invisible"] = p.Value;

                dt.Rows.Add(row);
            }

            dgvParticipants.DataSource = dt;
        }

    }
}
