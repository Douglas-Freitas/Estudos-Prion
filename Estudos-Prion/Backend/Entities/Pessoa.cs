﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
