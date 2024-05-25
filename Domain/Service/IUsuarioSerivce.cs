using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public interface IUsuarioService
    {
        public Usuario SaveUsuario(Usuario usuario);
        public Task<bool> Login(LoginRequestCommand login);
    }
}
