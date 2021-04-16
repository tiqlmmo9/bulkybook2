using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.Extensions;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.ISBN = product.ISBN;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.Author = product.Author;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }

        //public IEnumerable<Product> Search(string searchString)
        //{
        //    var products = from p in _db.Products
        //                   select p;
        //    if (string.IsNullOrWhiteSpace(searchString))
        //        return products;

        //    var lowerCaseTerm = Encoding.UTF8.GetString(Encoding.Default.GetBytes(searchString.Trim().ToLower()));

        //    products = products.Where(p => p.Title.Contains(lowerCaseTerm));

        //    return products;

        //}

        public PagedList<Product> GetProducts(ProductParameters productParameters)
        {
            var products = _db.Products.Search(productParameters.SearchTerm).OrderBy(p => p.Title).Sort(productParameters.OrderPrice).ToList();

            return PagedList<Product>.ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }
    }
}
