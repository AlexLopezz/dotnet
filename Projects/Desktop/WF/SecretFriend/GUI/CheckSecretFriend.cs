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
        Dictionary<string, string> participants;

        public CheckSecretFriend(Dictionary<string, string> participants)
        {
            InitializeComponent();
            this.participants = participants;
        }

        private void bttCheck_Click(object sender, EventArgs e)
        {

            if(participants.Any(p => p.Equals(txtName.Text)))
            {
                txtSecretFriend.Text = participants.GetValueOrDefault(txtSecretFriend.Text);
            }
        }
    }
}
