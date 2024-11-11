using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace LanchoneteContext.Configurations;

public class IngredienteConfiguration:IEntityTypeConfiguration<Ingrediente>
{
    public void Configure(EntityTypeBuilder<Ingrediente> builder)
    {
        builder.Property(u=>u.Nome).HasMaxLength(255).IsRequired();
        builder.Property(u=>u.DataValidadePadrao).HasColumnType("DATE");
    }
}