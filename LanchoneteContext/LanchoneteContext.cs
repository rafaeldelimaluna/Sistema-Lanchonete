using LanchoneteContext.Configurations;
using Microsoft.EntityFrameworkCore;
using Models;

namespace LanchoneteContext;

public class LanchoneteContext(DbContextOptions<LanchoneteContext> options) : DbContext(options)
{
    public DbSet<Usuarios>? Usuarios { get; set; }
    public DbSet<Ingredientes>? Ingredientes { get; set; }
    public DbSet<Produtos>? Produtos { get; set; }
    public DbSet<TipoProduto>? TipoProduto { get; set; }
    public DbSet<NivelAcesso>? NivelAcesso { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseSqlServer("Server=localhost;Database=Lanchonete;User Id=sa;Password=123456;Encrypt=False")
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}

