using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.Infrastructure.EntityConfig
{
    public class MovimentacaoMap : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {

            builder.HasKey(c => c.MovimentacaoId);
            builder.HasOne(c => c.Conta)
                .WithMany(c => c.Movimentacaos)
                .HasForeignKey(c => c.ContaId)
                .HasPrincipalKey(c => c.ContaId);
                
            
            //builder.Property(c => c.Descricao)
            //   .HasColumnType("varchar(230)")
            //    .IsRequired();

        }
    }
}
