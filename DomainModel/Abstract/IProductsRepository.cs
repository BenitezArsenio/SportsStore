using DomainModel.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Abstract
{
    //we are using a repository pattern to store the persistence logic of getting Product entities from db outside of the Product class
    public interface IProductsRepository
    {
        IQueryable<Product> Products { get; }
    }
}
