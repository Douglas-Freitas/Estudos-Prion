using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class GenericController<T> : Controller where T : class
    {
        private GenericService<T> service;
        public GenericController()
        {
            service = new GenericService<T>();
        }

        public virtual void Add(T entity)
        {
            service.Add(entity);
        }
        public virtual void Update(T entity)
        {
            service.Update(entity);
        }
        public virtual void Delete(T entity)
        {
            service.Delete(entity);
        }
        public virtual List<T> GetAll()
        {
            return service.GetAll();
        }
        public virtual T GetById(int id)
        {
            return service.GetById(id);
        }
    }
}