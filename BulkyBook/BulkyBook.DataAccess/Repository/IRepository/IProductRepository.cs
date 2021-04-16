using BulkyBook.Models;
using BulkyBook.Models.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);

        PagedList<Product> GetProducts(ProductParameters productParameters);
    }
}
