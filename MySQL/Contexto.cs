using Microsoft.EntityFrameworkCore;
using MySQL.Entidades;

namespace MySQL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option) { }

        public DbSet<Usuario> USUARIOS { get; set; }
    }
}
