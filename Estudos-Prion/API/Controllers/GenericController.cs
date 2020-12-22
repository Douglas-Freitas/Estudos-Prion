using Backend.Entities;
using Backend.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods:"*")]
    [Authorize]
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

        public Usuario UsuarioLogado 
        {
            get
            {
                var principal = (RequestContext.Principal as ClaimsPrincipal);
                var json = principal.Claims.Where(x => x.Type == "Usuario").FirstOrDefault().Value;

                Usuario logado = JsonConvert.DeserializeObject<Usuario>(json);

                return logado;
            }
            set
            {
                UsuarioLogado = value;
            } 
        }
    }
}