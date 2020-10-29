using Backend.Entities;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Controllers
{
    public class PessoaController : GenericController<Pessoa>
    {
        public PessoaController()
        {
            this.service = new PessoaService();
        }
    }
}