using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace LanchoneteContext.Configurations;

public class ProdutosConfiguration:IEntityTypeConfiguration<Produtos>
{
    public void Configure(EntityTypeBuilder<Produtos> builder)
    {
        builder.Property(u=>u.Nome).IsRequired().HasMaxLength(255);
        builder.Property(u=>u.Preco).IsRequired().HasColumnType("decimal(10,2)");
        builder.Property(u=>u.TipoProduto).HasConversion<string>().IsRequired();
    }
}