using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbani.Data_Access_Layer;

namespace umbani.Models
{
    public class Company
    {
        private int id;
        private string companyName;
        private Contact contactId;
        public int Id { get => id; set => id = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public Contact ContactId { get => contactId; set => contactId = value; }

        public Company()
        {

        }

        public Company(int id, string name,Contact contact)
        {
            this.contactId = contact;
            this.companyName = name;
            this.id = id;
        }
        DataHandler dh = new DataHandler();

        public List<Company> GetCompanies()
        {
            return dh.GetCompanies();
        }

       
        public bool SaveCompany(string name, int companyID)
        {
            return dh.SaveCompany(name,companyID);
        }

        public bool UpdateCompany(string name, int compnyid)
        {
            return dh.UpdateCompany(name, compnyid);
        }

        public bool DeleteCompany(int compnyid)
        {
            return dh.DeleteCompany(compnyid);
        }
    }
}