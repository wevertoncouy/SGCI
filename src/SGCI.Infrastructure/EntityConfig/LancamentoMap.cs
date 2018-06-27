using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.Infrastructure.EntityConfig
{
    public class LancamentoMap : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder.Property(e => e.Descricao)
               .HasColumnType("varchar(150)")
                .IsRequired();

            
            builder.HasOne(C => C.Conta)
                .WithMany(c => c.Lancamentos)
                 .HasForeignKey(c => c.ContaId)
                .HasPrincipalKey(c => c.ContaId);
        }
    }
}
