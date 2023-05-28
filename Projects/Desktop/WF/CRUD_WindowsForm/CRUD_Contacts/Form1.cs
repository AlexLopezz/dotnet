using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Contacts
{
    public partial class Main : Form
    {
        private BusinessLogicLayer _bussinessLogicLayer;
        public Main()
        {
            InitializeComponent();
            this.CenterToScreen();
            _bussinessLogicLayer = new BusinessLogicLayer();
        }


        #region EVENTS
        private void bttAdd_Click(object sender, EventArgs e)
        {
            OpenContactDialog();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }
        #endregion

        #region PRIVATE METHODS
        private void OpenContactDialog()
        {
            FormContact contact = new FormContact();
            contact.ShowDialog(this);
        }
        #endregion

        public void LoadContacts(String search = null)
        {
            List<Contact> contacts = new List<Contact>();

            contacts = _bussinessLogicLayer.getContacts(search);
            dgvContacts.DataSource = contacts;
        }
        private void bttSearch_Click(object sender, EventArgs e)
        {
            this.LoadContacts(txtSearch.Text);
            txtSearch.Text = String.Empty;
        }

        private void dgvContacts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell btt = (DataGridViewButtonCell)dgvContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (btt.Value.ToString() == "Edit")
            {
                FormContact contact = new FormContact();
                contact.ChargeFormContacts(new Contact
                {
                    Id = int.Parse(dgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = dgvContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = dgvContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = dgvContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = dgvContacts.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });

                contact.ShowDialog(this);

            }
            else if (btt.Value.ToString() == "Delete")
            {
                int id = int.Parse(dgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString());
                _bussinessLogicLayer.DeleteContact(id);
                MessageBox.Show("Contacto eliminado con exito.");
                this.LoadContacts();
            }
        }
    }
}
