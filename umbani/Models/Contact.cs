using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbani.Data_Access_Layer;

namespace umbani.Models
{
    public class Contact
    {
        private int id;
        private string name;
        private string number;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }

        public Contact()
        {
            
        }

        public Contact(int id,string name,string number,string email)
        {
            this.id = id;
            this.name = name;
            this.number = number;
            this.email = email;
        }

        DataHandler dh = new DataHandler();

        public List<Contact> GetContacts()
        {
            return dh.GetContacts();
        }
        public bool SaveContact(string companyname, string phone, string companyemail)
        {
            return dh.SaveContact(companyname, phone, companyemail);
        }

        public bool UpdateContact(string companyname, string phone, string companyemail, int companyId, int contactId)
        {
            return dh.UpdateContact(companyname, phone, companyemail, companyId,id);
        }

        public bool DeleteContact(int contactId)
        {
            return dh.DeleteCompany(contactId);
        }
    }
}