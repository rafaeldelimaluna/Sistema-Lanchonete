using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace LanchoneteContext.Configurations;

public class TipoProdutoConfiguration:IEntityTypeConfiguration<TipoProduto>
{
    public void Configure(EntityTypeBuilder<TipoProduto> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Nome).HasMaxLength(50).IsRequired();
    }
}