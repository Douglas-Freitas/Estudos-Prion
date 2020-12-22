using Backend.Entities;
using Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class UsuarioService : GenericService<Usuario>
    {
        private UsuarioRepository usuarioRepository;
        public UsuarioService()
        {
            usuarioRepository = new UsuarioRepository();
        }
        public Usuario GetUsuarioPorEmail(string email)
        {
            return usuarioRepository.GetUsuarioPorEmail(email);
        }
    }
}
