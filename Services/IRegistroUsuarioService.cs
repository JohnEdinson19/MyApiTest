using MyAPI.Models;

namespace MyAPI.Services
{
    public interface IRegistroUsuarioService
    {
        void RegistrarUsuario(UsuarioModel usuario);
    }
}
