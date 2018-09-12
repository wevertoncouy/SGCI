using Microsoft.EntityFrameworkCore;
using SGCI.ApplicationCore.Entity;
using SGCI.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.Infrastructure.Data
{
    public class GestaoCarteiraContext : DbContext
    {
        public GestaoCarteiraContext(DbContextOptions<GestaoCarteiraContext> options) : base(options)
        {

        }
        // mapeamento
        public DbSet<Movimentacao> Movimentacaos { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }


        ///Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimentacao>().ToTable("Movimentacao");
            modelBuilder.Entity<Conta>().ToTable("Conta");
            modelBuilder.Entity<Lancamento>().ToTable("Lancamento");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.ApplyConfiguration (new MovimentacaoMap());
            modelBuilder.ApplyConfiguration (new ContaMap());
            modelBuilder.ApplyConfiguration (new LancamentoMap());
            modelBuilder.ApplyConfiguration (new CategoriaMap());


            #region Configurations de Carteira



            #endregion

            #region Configurations de Conta


            #endregion


            #region Configurations Menu
            //modelBuilder.Entity<Menu>()
            // .HasMany(x => x.SubMenu)
            // .WithOne()
            // .HasForeignKey(x => x.MenuId);
            #endregion
        }




    }
}
