using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Ait.UnitsCloud.PortalApi.Data.Repositories
{
    public abstract class GenericRepository<C, T> : IGenericRepository<T> where T : class where C : DbContext, new()
    {
       C _Context = null;
        public GenericRepository(C Context)
        {
            _Context =Context;
        }
        public C Context
        {
            get { return _Context; }
            set { _Context = value; }
        }
        public void Add(T entity)
        {
            _Context.Set<T>().Add(entity);
        }
        public void Delete(T entity)
        {
           _Context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _Context.Set<T>().Update(entity);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _Context.Set<T>().Where(predicate);
        }
        public IQueryable<T> GetAll()
        {
            return _Context.Set<T>();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}