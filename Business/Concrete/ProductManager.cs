using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        //ProductManager newlendiğinde bir IProductDal referansı alan constructer  bunlar ileride başka veri erişim alternatiflerine dönüşebilir

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            // returnden önce logic operasyonlar bulunur. bunlardan geçtirkten sonra return edilir

            return _productDal.GetAll();
        }
    }
}
