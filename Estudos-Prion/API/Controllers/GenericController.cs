using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class GenericController<T> : ApiController where T : class
    {
        protected GenericService<T> service;
        public GenericController()
        {
            service = new GenericService<T>();
        }

        [HttpPost]
        public virtual void Add(T entity)
        {
            service.Add(entity);
        }

        [HttpPut]
        public virtual void Update(T entity)
        {
            service.Update(entity);
        }

        [HttpDelete]
        public virtual void Delete(T entity)
        {
            service.Delete(entity);
        }

        [HttpGet]
        public virtual List<T> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet]
        public virtual T GetById(int id)
        {
            return service.GetById(id);
        }
    }
}