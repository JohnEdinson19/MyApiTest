namespace MyAPI.Models
{
    public class UsuarioModel
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int PaisID { get; set; }
        public int DepartamentoID { get; set; }
        public int MunicipioID { get; set; }
        public string Direccion { get; set; }
    }
}
