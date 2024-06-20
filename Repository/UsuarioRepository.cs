using Domain.Entity;
using Domain.Repository;
using Infra;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : BaseRepository<Usuario, int>, IUsuarioRepository
    {
        public UsuarioRepository(UsuarioDbContext db)
            : base(db)
        {
        }

        public async Task<Usuario?> GetUsuario(string user)
        {
            var results = await GetAll();
            return results.FirstOrDefault(usuario => usuario.Email.Equals(user, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Usuario> SaveAsync(Usuario usuario)
        {
            return await Add(usuario);
        }

        public async Task<List<Usuario>> GetAllUsuarios()
        {
            return await GetAll();
        }

        public async Task UpdateUsuarioAsync(Usuario usuario)
        {
            await Update(usuario);
        }
    }
}
