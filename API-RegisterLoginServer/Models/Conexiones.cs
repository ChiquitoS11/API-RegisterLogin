using Microsoft.EntityFrameworkCore;

namespace API_RegisterLoginServer.Models
{
    public class Conexiones : DbContext
    {
        public Conexiones(DbContextOptions<Conexiones> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; } = null!;
    }
}
