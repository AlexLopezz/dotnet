using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CRUD_Contacts
{
    public class DataAccessLayer
    {
        private SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CrudContactsWinForms;Data Source=DESKTOP-5LJUDM0\\SQLEXPRESS");

        internal void DeleteContact(int id)
        {
            try
            {
                sqlConnection.Open();
                String querySQL = @"DELETE FROM Contacts WHERE id = @id";
                SqlParameter idP = new SqlParameter("@id", id);

                SqlCommand command = new SqlCommand(querySQL, sqlConnection);
                command.Parameters.Add(idP);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        internal List<Contact> getContacts(String search = null)
        {
            List < Contact > contacts = new List<Contact> ();
            try
            {
                sqlConnection.Open();
                String querySQL = @"SELECT id, firstName, lastName, phone, addres 
                                    FROM Contacts ";

                SqlCommand command = new SqlCommand();

                if (!String.IsNullOrEmpty(search))
                {
                    querySQL += @"WHERE firstName LIKE @search OR lastName LIKE @search;";
                    SqlParameter searchP = new SqlParameter("@search", $"%{search}%");
                    command.Parameters.Add(searchP);
                }
                command.CommandText = querySQL;
                command.Connection = sqlConnection;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(
                        new Contact
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            FirstName = reader["firstName"].ToString(),
                            LastName = reader["lastName"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Address = reader["addres"].ToString()
                        });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
                sqlConnection.Close();
            }
            return contacts;
        }

        internal void InsertContact(Contact contact)
        {
            try
            {
                sqlConnection.Open();
                String sql = @"INSERT INTO Contacts(firstName, lastName, phone, addres)
VALUES(@firstName, @lastName, @phone, @addres);";

                SqlParameter firstName = new SqlParameter("@firstName", contact.FirstName);
                SqlParameter lastName = new SqlParameter("@lastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@phone", contact.Phone);
                SqlParameter addres = new SqlParameter("@addres", contact.Address);

                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(addres);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        internal void UpdateContact(Contact contact)
        {
            try
            {
                sqlConnection.Open();
                String querySQL = @"UPDATE Contacts SET firstName = @firstName,
                                                        lastName = @LastName,
                                                        phone = @phone,
                                                        addres = @addres
                                    WHERE id = @id";

                SqlParameter firstName = new SqlParameter("@firstName", contact.FirstName);
                SqlParameter lastName = new SqlParameter("@lastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@phone", contact.Phone);
                SqlParameter addres = new SqlParameter("@addres", contact.Address);

                SqlParameter id = new SqlParameter("@id", contact.Id);


                SqlCommand command = new SqlCommand(querySQL,sqlConnection);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(addres);
                
                command.Parameters.Add(id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
