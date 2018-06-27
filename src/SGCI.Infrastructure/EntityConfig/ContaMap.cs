using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.Infrastructure.EntityConfig
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
             builder.Property(e => e.Nome)
               .HasColumnType("varchar(150)")
                .IsRequired();

            builder.HasMany(c => c.Movimentacaos)
                .WithOne(c => c.Conta)
                .HasForeignKey(c => c.ContaId)
                .HasPrincipalKey(c => c.ContaId);

            builder.HasMany(c => c.Lancamentos)
                .WithOne(c => c.Conta)
                .HasForeignKey(c => c.ContaId)
                .HasPrincipalKey(c => c.ContaId);

        }
    }
}
