﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SGCI.ApplicationCore.Entity;
using SGCI.Infrastructure.Data;
using System;

namespace SGCI.Infrastructure.Migrations
{
    [DbContext(typeof(GestaoCarteiraContext))]
    [Migration("20180911114305_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descriao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Conta", b =>
                {
                    b.Property<int>("ContaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataConta");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<decimal>("Saldo");

                    b.Property<int>("TipoMoeda");

                    b.Property<int>("UsuarioId");

                    b.HasKey("ContaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Lancamento", b =>
                {
                    b.Property<int>("LancamentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<int>("ContaId");

                    b.Property<DateTime>("DataLancamento");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("StatusLancamento");

                    b.Property<decimal>("Valor");

                    b.HasKey("LancamentoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ContaId");

                    b.ToTable("Lancamento");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Movimentacao", b =>
                {
                    b.Property<int>("MovimentacaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContaId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int>("TipoMovimentacao");

                    b.Property<decimal>("Valor");

                    b.HasKey("MovimentacaoId");

                    b.HasIndex("ContaId");

                    b.ToTable("Movimentacao");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Conta", b =>
                {
                    b.HasOne("SGCI.ApplicationCore.Entity.Usuario", "Usuario")
                        .WithMany("Contas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Lancamento", b =>
                {
                    b.HasOne("SGCI.ApplicationCore.Entity.Categoria", "Categoria")
                        .WithMany("Lancamentos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SGCI.ApplicationCore.Entity.Conta", "Conta")
                        .WithMany("Lancamentos")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Movimentacao", b =>
                {
                    b.HasOne("SGCI.ApplicationCore.Entity.Conta", "Conta")
                        .WithMany("Movimentacaos")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}