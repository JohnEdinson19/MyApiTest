using MyAPI.Models;
using Npgsql;
using System.Data;

namespace MyAPI.Services
{
    public class RegistroUsuarioService : IRegistroUsuarioService
    {
        private readonly NpgsqlConnection _connection;
        private readonly ILogger<RegistroUsuarioService> _logger;

        public RegistroUsuarioService(NpgsqlConnection connection, ILogger<RegistroUsuarioService> logger)
        {
            _connection = connection;
            _logger = logger;
        }

        public void RegistrarUsuario(UsuarioModel usuario)
        {
            try
            {
                _connection.Open();

                using (var command = new NpgsqlCommand("testapi.insertar_usuario", _connection))
                {
                    _logger.LogWarning($"[{DateTime.Now}]: Registrando al usuario: {usuario.Nombre}");
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("p_nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("p_telefono", usuario.Telefono);
                    command.Parameters.AddWithValue("p_id_pais", usuario.PaisID);
                    command.Parameters.AddWithValue("p_id_departamento", usuario.DepartamentoID);
                    command.Parameters.AddWithValue("p_id_municipio", usuario.MunicipioID);
                    command.Parameters.AddWithValue("p_direccion", usuario.Direccion);
                    command.ExecuteNonQuery();
                    _logger.LogInformation($"[{DateTime.Now}]: el usuario {usuario.Nombre} fue registrado exitosamente");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"[{DateTime.Now}]: Error al registrar el usuario: {ex.Message}");

                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
    }

}
