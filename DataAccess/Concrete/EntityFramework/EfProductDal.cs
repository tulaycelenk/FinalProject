using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfProductDal : IProductDal

    {
        public void Add(Product entity)
        {
            using (NorthwindContex context = new NorthwindContex())
            {
                //veri kaynağından gönderdiğim producttan bir tane nesneye eşleştir referansı alıyor
                var addedEntity = context.Entry(entity);
                //Entity state ekleme silme güncelleme gibi işlemleri var burada ekleme yapıyoruz
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }        
        }

        public void Delete(Product entity)
        {
            using (NorthwindContex context = new NorthwindContex())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContex context = new NorthwindContex())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (NorthwindContex context = new NorthwindContex())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
