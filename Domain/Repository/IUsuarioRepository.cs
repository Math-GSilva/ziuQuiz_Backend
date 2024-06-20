using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IUsuarioRepository
    {
        public Task<Usuario?> GetUsuario(string user);
        public Task<Usuario> SaveAsync(Usuario usuario);
        public Task<List<Usuario>> GetAllUsuarios();
        public Task UpdateUsuarioAsync(Usuario usuario);

    }
}
