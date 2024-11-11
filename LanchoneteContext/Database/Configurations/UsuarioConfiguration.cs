using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace LanchoneteContext.Configurations;

public class UsuarioConfiguration:IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.Property(u => u.Id).ValueGeneratedOnAdd();
        builder.Property(u => u.Nome).IsRequired().HasMaxLength(80);
        builder.HasIndex(u=>u.Nome);
        builder.Property(u=>u.Senha).IsRequired().HasMaxLength(255);
    }
}