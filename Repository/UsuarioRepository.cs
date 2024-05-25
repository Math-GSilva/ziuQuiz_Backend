using Domain.Entity;
using Domain.Repository;
using Infra;

namespace Repository
{
    public class UsuarioRepository : BaseRepository<Usuario, int>, IUsuarioRepository
    {
        public UsuarioRepository() { }

        public UsuarioRepository(UsuarioDbContext db)
            : base(db)
        {
        }
        public async Task<Usuario?> GetUsuario(string user)
        {
            var results = await base.GetAll();
            return results.Find(usuario => usuario.Email.Equals(user, StringComparison.Ordinal));
        }

        public Usuario Save(Usuario usuario) => Add(usuario);

        public Task<List<Usuario>> GetAllUsuarios() => base.GetAll();

        public void UpdateUsuario(Usuario usuario) => base.Update(usuario);
    }
}
