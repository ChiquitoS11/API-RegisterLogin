using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace LoginRegister.Models
{
    public class Conexiones : DbContext
    {
        public Conexiones(DbContextOptions<Conexiones> options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; } = null!;
    }
}
