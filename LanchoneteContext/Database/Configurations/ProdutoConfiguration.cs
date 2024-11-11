using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace LanchoneteContext.Database.Configurations;

public class ProdutoConfiguration:IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.Property(u=>u.Nome).IsRequired().HasMaxLength(255);
        builder.Property(u=>u.Preco).IsRequired().HasColumnType("decimal(10,2)");
        builder.Property(u=>u.TipoProduto).HasConversion<string>(
            tipoProduto=>tipoProduto.ToString()!,
            tipoProduto=> (TipoProduto)Enum.Parse(typeof(TipoProduto),tipoProduto)
            ).IsRequired();
    }
}