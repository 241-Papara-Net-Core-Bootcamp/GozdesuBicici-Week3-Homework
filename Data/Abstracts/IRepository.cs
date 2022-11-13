using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Abstracts
{
    public interface IRepository<T> where T : class
    {
        //Ekstra olarak Find metodu belli bir sorguya göre bulmak için
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll();
        T GetById(Guid id);
        void Post(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
