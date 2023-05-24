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
    public partial class FormContact : Form
    {
        Contact _contact;
        private BusinessLogicLayer _businessLogicLayer;

        public FormContact()
        {
            InitializeComponent();
            this.CenterToScreen();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        #region PRIVATE METHODS
        private void CloseThisForm()
        {
            this.Close();
        }
        private void CreateContact()
        {
            Contact contact = new Contact();
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Address = txtAddress.Text;

            contact.Id = _contact != null ? _contact.Id : 0;
            _businessLogicLayer.SaveContact(contact);
        }
        private void CleanFieldsForm()
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtAddress.Text = String.Empty;
        }
        #endregion

        #region EVENTS
        private void bttCancel_Click(object sender, EventArgs e)
        {
            CloseThisForm();
        }

        #endregion

        private void bttSave_Click(object sender, EventArgs e)
        {
            CreateContact();
            ((Main)this.Owner).LoadContacts();
            MessageBox.Show("Contacto agregado!");
        }
        public void ChargeFormContacts(Contact contact)
        {
            if(contact != null)
            {
                CleanFieldsForm();
                txtLastName.Text = contact.LastName;
                txtFirstName.Text = contact.FirstName;
                txtAddress.Text = contact.Address;
                txtPhone.Text = contact.Phone;
                _contact = contact;
            }
        }
    }
}
