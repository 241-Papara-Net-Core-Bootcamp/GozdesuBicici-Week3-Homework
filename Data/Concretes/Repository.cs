using Data.Abstracts;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Data.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public AppDbContext Context { get; }
        public Repository(AppDbContext context)
        {
            Context = context;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>()
                .Where(expression)
                .AsQueryable();
        }
        public IQueryable<T> GetAll()
        {
            // AsNoTracking(): Minimum bellek kullanımı ve optimum performans sağlayacaktır.
            return Context.Set<T>().AsNoTracking();
        }

        public T GetById(Guid id)
        {            
            return Context.Set<T>().Find(id);
        }

        public void Post(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }
    }
}
