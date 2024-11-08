using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace LanchoneteContext.Configurations;

public class IngredientesConfiguration:IEntityTypeConfiguration<Ingredientes>
{
    public void Configure(EntityTypeBuilder<Ingredientes> builder)
    {
        builder.Property(u=>u.Nome).HasMaxLength(255).IsRequired();
        builder.Property(u=>u.DataValidadePadrao).HasColumnType("DATE");
    }
}