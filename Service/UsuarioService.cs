using Domain.Entity;
using Domain.Repository;
using Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public async Task<bool> Login(LoginRequestCommand login)
        {
            var user = await usuarioRepository.GetUsuario(login.Email);
            if (user == null)
            {
                return false;
            }
            else
            {
                bool isValid = BCrypt.Net.BCrypt.Verify(login.Password, user.Password);
                if (isValid)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<Usuario> SaveUsuarioAsync(Usuario usuario)
        {
            usuario.Password = BCrypt.Net.BCrypt.HashPassword(usuario.Password);
            return await usuarioRepository.SaveAsync(usuario);
        }
    }
}
