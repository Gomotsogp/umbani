using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using umbani.Data_Access_Layer;

namespace umbani.Models
{
    public class Subscription
    {
        private int id;
        private Company companyId;
        private Contact contactId;
        private Product productId;
        private int numberOfUsers;
        private DateTime subscriptionStartDate;
        private bool annual;
        private bool monthly;
        private decimal cost;
        private UserContext user;

        public int Id { get => id; set => id = value; }
        public Company CompanyId { get => companyId; set => companyId = value; }
        public Contact ContactId { get => contactId; set => contactId = value; }
        public Product ProductId { get => productId; set => productId = value; }
        public int NumberOfUsers { get => numberOfUsers; set => numberOfUsers = value; }
        public DateTime SubscriptionStartDate { get => subscriptionStartDate; set => subscriptionStartDate = value; }
        public bool Annual { get => annual; set => annual = value; }
        public bool Monthly { get => monthly; set => monthly = value; }
        public decimal Cost { get => cost; set => cost = value; }

        public Subscription()
        {
                
        }

        public Subscription(int id, Company companyId,Contact contact, Product product, int  noOFusers,DateTime startdate,bool annual,bool monthly,decimal cost)
        {
            this.id = id;
            this.companyId = companyId;
            this.contactId = contact;
            this.productId = product;
            this.numberOfUsers = noOFusers;
            this.subscriptionStartDate = startdate;
            this.annual = annual;
            this.monthly = monthly;
            this.cost = cost;
        }

        DataHandler dh = new DataHandler();
        public List<Subscription> GetSubscriptions()
        {
            return dh.GetSubscriptions();
        }

        public List<Subscription> GetSubscription(int id)
        {
            return dh.GetSubscription(id);
        }
        public bool SaveSubscription(int companyId, int contactId, int productId, int numberofUsers, DateTime startDate, bool annual, bool monthly, decimal cost)
        {
            return dh.SaveSubscription(companyId, contactId, productId, numberofUsers, startDate,  annual,  monthly,  cost);
        }

        public bool UpdateSubscription(int companyId, int contactId, int productId, int numberofUsers, DateTime startDate, bool annual, bool monthly, decimal cost, int id)
        {
            return dh.UpdateSubscription(companyId, contactId, productId, numberofUsers, startDate, annual, monthly, cost, id);
        }

        public bool DeleteSubscription(int id)
        {
            return dh.DeleteSubscription(id);
        }
    }
}