using System;
using System.Collections.Generic;
using System.Text;

namespace FIlesExercice.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal TotalPrice()
        {
            return Price * Quantity; 
        }
    }
}
