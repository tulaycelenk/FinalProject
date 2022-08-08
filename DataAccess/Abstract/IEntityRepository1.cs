using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{


    public interface IEntityRepository<T>
    {
        //filter==null filtre vermezse tüm datayı istiyordur
        //Expression filterleme yapmamızı sağlıyor linqle olduğu gibi
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //filtre verdi 1 şey gösterecek içerik detay sayfasında olduğu gibi
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}