using Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class GenericService<T> : IDisposable where T : class
    {
        private GenericRepository<T> repository;
        public GenericService()
        {
            repository = new GenericRepository<T>();
        }

        public virtual void Add(T entity)
        {
            repository.Add(entity);
        }
        public virtual void Update(T entity)
        {
            repository.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public virtual List<T> GetAll()
        {
            return repository.GetAll();
        }
        public virtual T GetById(int id)
        {
            return repository.GetById(id);
        }
        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
