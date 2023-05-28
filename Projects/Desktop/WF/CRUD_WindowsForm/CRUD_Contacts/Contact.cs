using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Contacts
{
    public class Contact
    {
        public int Id { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }

        public Contact()
        { }
        public Contact(int id, String lastName, String firstName, String phone, String addres)
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Phone = phone;
            this.Address = addres;
        }
    }
}
