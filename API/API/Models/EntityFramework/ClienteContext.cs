using System.Diagnostics.Metrics;
using System;
using Microsoft.EntityFrameworkCore;

namespace API.Models.EntityFramework
{
    public class ClienteContext : DbContext
    {
        public DbSet<PaisEF> t_paises{ get; set; }
        public DbSet<ClienteEF> t_clientes { get; set; }

        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteEF>()
            .HasOne(c => c.Pais_Ef)
            .WithMany()
            .HasForeignKey(c => c.id_pais);
        }
    }
}
