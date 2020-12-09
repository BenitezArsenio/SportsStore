using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Entites
{
    //domain model is the heart of the application. This is an e-commerce application and the most obvious domain entity is a product.
    //needs to be public not internal bc we need to access it from my other projects.
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set;}
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
