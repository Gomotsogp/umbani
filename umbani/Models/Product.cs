using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbani.Data_Access_Layer;

namespace umbani.Models
{
    public class Product
    {
        private int id;
        private string productName;
        private decimal annualCost;
        private decimal monthlyCost;
        
        public Product()
        {
                
        }

        public Product(int id, string name,decimal annualcost,decimal monthlyCost)
        {
            this.id = id;
            this.productName = name;
            this.annualCost = annualcost;
            this.monthlyCost = monthlyCost;
        }

        public int Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal AnnualCost { get => annualCost; set => annualCost = value; }
        public decimal MonthlyCost { get => monthlyCost; set => monthlyCost = value; }

        DataHandler dh = new DataHandler();
        public List<Product> GetProducts()
        {
            return dh.GetProducts();
        }

        public bool SaveProduct(string name, decimal annualcost, decimal monthlycost)
        {
            return dh.SaveProduct(name, annualcost, monthlycost);
        }

        public bool UpdateProduct(string name, decimal annual,  decimal monthly, int id)
        {
            return dh.UpdateProduct(name, annual, monthly, id);
        }

        public bool DeleteProduct(int id)
        {
            return dh.DeleteProduct(id);
        }
    }
}