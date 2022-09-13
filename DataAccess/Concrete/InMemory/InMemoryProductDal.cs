using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryProductDal : IProductDal
    {
        
           //global değişken -referans tip -
           List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product { ProductId = 1, CategoryId = 1, ProductName="bardak", UnitPrice=15, UnitsInStock=15 }, 
                new Product { ProductId = 2, CategoryId = 1, ProductName = "kamera", UnitPrice = 500, UnitsInStock = 3 },
                new Product { ProductId = 3, CategoryId = 2, ProductName = "telefon", UnitPrice = 1500, UnitsInStock = 2 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "klavye", UnitPrice = 150, UnitsInStock = 65 },
                new Product { ProductId = 5, CategoryId = 2, ProductName="fare", UnitPrice=85 ,UnitsInStock=1 }};
        }
        public void Add(Product product)
        {
            //businessten gönderilen product _products a ekleniyor
            _products.Add(product);
        }

        public void Delete(Product product)
        {
             Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //Bulunan referans numaralı ürünün (productToUpdate) adını kategorisini ve diğer özelliklerini gönderilen (product) yeni verilerle değiştirme kodları
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
