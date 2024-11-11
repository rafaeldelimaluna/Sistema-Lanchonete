using LanchoneteContext.Configurations;
using Microsoft.EntityFrameworkCore;
using Models;

namespace LanchoneteContext;

public class LanchoneteContext(DbContextOptions<LanchoneteContext> options) : DbContext(options)
{
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Ingrediente>? Ingredientes { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<TipoProduto>? TipoProduto { get; set; }
    public DbSet<NivelAcesso>? NivelAcesso { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseSqlServer("Server=localhost;Database=Lanchonete;User Id=sa;Password=231564Ra@Ms;Encrypt=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new IngredienteConfiguration());
        modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        modelBuilder.ApplyConfiguration(new TipoProdutoConfiguration());
        modelBuilder.ApplyConfiguration(new NivelAcessoConfiguration());
    }
}

