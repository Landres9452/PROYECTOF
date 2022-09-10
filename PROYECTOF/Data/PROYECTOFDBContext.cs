using Microsoft.EntityFrameworkCore;
using PROYECTOF.Models;

namespace PROYECTOF.Data
{
    public class PROYECTOFDBContext : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

        public PROYECTOFDBContext(DbContextOptions<PROYECTOFDBContext> options): base(options)
        {
        }
    }
}
