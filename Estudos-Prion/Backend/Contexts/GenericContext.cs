using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Contexts
{
    public class GenericContext : DbContext
    {
        public GenericContext() : base("banco de dados") 
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
