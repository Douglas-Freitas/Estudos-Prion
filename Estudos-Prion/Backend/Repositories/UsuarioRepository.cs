using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>
    {
        public Usuario GetUsuarioPorEmail(string email)
        {
            return this.context.Usuarios.Where(usuario => usuario.Email == email).FirstOrDefault();
        }
    }
}
