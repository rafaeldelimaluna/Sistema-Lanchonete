using LanchoneteContext.Configurations;
using LanchoneteContext.Database.Configurations;
using Microsoft.EntityFrameworkCore;
using Models;

namespace LanchoneteContext.Database;

public class LanchoneteContext: DbContext
{
    public DbSet<Usuario>? Usuarios { get; set; }= null!;
    public DbSet<Ingrediente>? Ingredientes { get; set; }= null!;
    public DbSet<Produto>? Produtos { get; set; }= null!;
    public DbSet<TipoProduto> TipoProduto { get; set; }= null!;
    public DbSet<NivelAcesso> NivelAcesso { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=Lanchonete;User Id=sa;Password=;Encrypt=False");
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

