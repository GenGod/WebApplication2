using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private double price;
        private string category;

        public Product(int id, string name, string description, double price, string category)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.category = category;
        }
    }
}