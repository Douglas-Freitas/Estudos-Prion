using Backend.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class GenericRepository<T> : IDisposable where T : class
    {
        protected GenericContext context;

        public GenericRepository()
        {
            context = new GenericContext();
        }

        public virtual void Add(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
