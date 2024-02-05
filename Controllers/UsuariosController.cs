using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;
using MyAPI.Services;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IRegistroUsuarioService _registroUsuarioService;

        public UsuariosController(IRegistroUsuarioService registroUsuarioService)
        {
            _registroUsuarioService = registroUsuarioService;
        }

        [HttpPost]
        public IActionResult RegistrarUsuario([FromBody] UsuarioModel usuario)
        {
            try
            {
                _registroUsuarioService.RegistrarUsuario(usuario);
                return Ok("Usuario registrado exitosamente.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al registrar el usuario: {ex.Message}");
            }
        }
    }
}
