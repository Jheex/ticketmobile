using Microsoft.EntityFrameworkCore;
using TicketMobile.Models;

namespace TicketMobile.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuarios");
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Nome).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Perfil).IsRequired().HasMaxLength(50);
                entity.Property(u => u.Telefone).HasMaxLength(20);
                entity.Property(u => u.Departamento).HasMaxLength(50);
                entity.Property(u => u.Observacoes).HasMaxLength(500);
                entity.Property(u => u.SenhaHash).IsRequired().HasMaxLength(255);
            });
        }
    }
}
