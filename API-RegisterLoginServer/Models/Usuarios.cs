namespace API_RegisterLoginServer.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Contrasenia { get; set; }
        public required string Correo { get; set; }
    }
}
