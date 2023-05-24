using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Contacts
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;
        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }
        public void SaveContact(Contact contact)
        {
            if (contact.Id == 0)
                _dataAccessLayer.InsertContact(contact);
            else
                _dataAccessLayer.UpdateContact(contact);
        }

        internal List<Contact> getContacts(String search = null)
        {
            return _dataAccessLayer.getContacts(search);
        }
        public void DeleteContact(int id)
        {
            _dataAccessLayer.DeleteContact(id);
        }
    }
}
