using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product { ProductId = 1, CategoryId = 1, ProductName="bardak", UnitPrice=15, UnitsInStock=15 }, 
                new Product { ProductId = 2, CategoryId = 1, ProductName = "kamera", UnitPrice = 15, UnitsInStock = 15 },
                new Product { ProductId = 3, CategoryId = 2, ProductName = "telefon", UnitPrice = 15, UnitsInStock = 15 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "klavye", UnitPrice = 15, UnitsInStock = 15 },
                new Product { ProductId = 5, CategoryId = 2, ProductName="fare", UnitPrice=15, UnitsInStock=15 }};
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
