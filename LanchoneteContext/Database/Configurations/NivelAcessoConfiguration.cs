using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace LanchoneteContext.Configurations;

public class NivelAcessoConfiguration:IEntityTypeConfiguration<NivelAcesso>
{
    public void Configure(EntityTypeBuilder<NivelAcesso> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.TiposAcessos).HasConversion<string>();
    }
}