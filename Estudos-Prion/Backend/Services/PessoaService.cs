using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class PessoaService : GenericService<Pessoa>
    {
        public override List<Pessoa> GetAll()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            
            Pessoa pessoa = new Pessoa();
            pessoa.PessoaId = 1;
            pessoa.Nome = "Cazuza";
            pessoa.Email = "patati@gmail.com";
            pessoas.Add(pessoa);

            Pessoa pessoa2 = new Pessoa();
            pessoa2.PessoaId = 2;
            pessoa2.Nome = "O Novinha";
            pessoa2.Email = "querotevercontente@gmail.com";
            pessoas.Add(pessoa2);

            Pessoa pessoa3 = new Pessoa();
            pessoa3.PessoaId = 3;
            pessoa3.Nome = "Azul Piscina";
            pessoa3.Email = "livin@gmail.com";
            pessoas.Add(pessoa3);

            return pessoas;
        }
    }
}
