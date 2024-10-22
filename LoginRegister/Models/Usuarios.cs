namespace LoginRegister.Models
{
    public class Usuarios
    {
        public Int32 Id { get; set; }
        public required string Usuario { get; set; }
        public required string Contrasenia { get; set; }
        public required string Correo { get; set; }
    }
}
