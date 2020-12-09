using DomainModel.Abstract;
using DomainModel.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Concrete
{
    class FakeProductsRepository : IProductsRepository
    {
        //fake hard-coded list of products
        private static IQueryable<Product> fakeProducts = new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product {Name = "Surf board", Price = 179},
            new Product {Name = "Running Shoes", Price = 95}
        }.AsQueryable();
        public IQueryable<Product> Products
        {
            get { return fakeProducts;  }
        }
    }
}
