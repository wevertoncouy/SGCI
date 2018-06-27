using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCI.Infrastructure.Data
{
    public static class DbInitializer
    {

        public static void Initialize(GestaoCarteiraContext context)
        {
            if (context.Movimentacaos.Any())
            {
                return;
            }

            var usuarios = new Usuario[]
            {
                new Usuario
                {
                    Nome = "Matheus Diego",
                    Email = "Ferando123@gmail.com"
                },

                 new Usuario
                {
                    Nome = "Weverton couy",
                    Email = "Couy@gmail.com"
                },

                  new Usuario
                {
                    Nome = "Maria da Silva",
                    Email = "Grakas@gmail.com"
                }
            };
            context.AddRange(usuarios);

            var contas = new Conta[]
            {
                new Conta
                {
                    DataConta = DateTime.Parse("2018-01-01"),
                    Nome = "Conta renda fixa",
                    Saldo = 10000,
                    TipoMoeda = TipoMoeda.Real,
                    Usuario = usuarios[1]
                },

                new Conta
                {
                    DataConta = DateTime.Parse("2018-01-01"),
                    Nome = "Conta Primaria ",
                    Saldo = 10000,
                    TipoMoeda = TipoMoeda.Dolar,
                    Usuario = usuarios[0]
                },

                new Conta
                {
                    DataConta = DateTime.Parse("2018-01-01"),
                    Nome = "Conta renda fixa",
                    Saldo = 10000,
                    TipoMoeda = TipoMoeda.Real,
                    Usuario = usuarios[0]
                }
            };
            context.AddRange(contas);

            var categorias = new Categoria[]
              {
                new Categoria
                {
                    Descriao = "Cambio",
                   
                },

                 new Categoria
                {
                    Descriao = "CDB",
                  
                },

                  new Categoria
                {
                    Descriao = "Ações",
                   
                }
            };
            context.AddRange(categorias);

            var lancamentos = new Lancamento[]
            {
               new Lancamento
               {
                DataLancamento = DateTime.Parse("2018-01-01"),
                Descricao = "Forex",
                Valor = 11000,
                Categoria = categorias[1],
                Conta = contas[1],
                StatusLancamento = StatusLancamento.Confirmado

               },

               new Lancamento
               {
                DataLancamento = DateTime.Parse("2018-01-01"),
                Descricao = "Cambio",
                Valor = 200,
                Categoria = categorias[1],
                Conta = contas[1],
                StatusLancamento = StatusLancamento.Confirmado

               },

                 new Lancamento
               {
                DataLancamento = DateTime.Parse("2018-01-01"),
                Descricao = "Indice",
                Valor = 12000,
                Categoria = categorias[0],
                Conta = contas[1],
                StatusLancamento = StatusLancamento.Confirmado

               }

            };
            context.AddRange(lancamentos);

            var movimentacaos = new Movimentacao[]
            {
               new Movimentacao
               {
                DataCadastro = DateTime.Parse("2018-01-01"),
                Valor = 1000,
                TipoMovimentacao = TipoMovimentacao.Deposito,
                Conta = contas[0],

               },

               new Movimentacao
               {
                DataCadastro = DateTime.Parse("2018-01-01"),
                Valor = 250,
                TipoMovimentacao= TipoMovimentacao.Saque,
                Conta = contas[0],

               },

               new Movimentacao
               {
                DataCadastro = DateTime.Parse("2018-01-01"),

                Valor = 100,
                TipoMovimentacao = TipoMovimentacao.Deposito,
                Conta = contas[1],

               },

               new Movimentacao
               {
                DataCadastro = DateTime.Parse("2018-01-01"),

                Valor = 500,
                TipoMovimentacao = TipoMovimentacao.Deposito,
                Conta = contas[1],

               },


               new Movimentacao
               {
                DataCadastro = DateTime.Parse("2018-01-01"),

                Valor = 500,
                TipoMovimentacao = TipoMovimentacao.Deposito,
                Conta = contas[2],

               },

               new Movimentacao
               {
                DataCadastro = DateTime.Parse("2018-01-01"),

                Valor = 250,
                TipoMovimentacao = TipoMovimentacao.Saque,
                Conta = contas[2],

               },




            };
            context.AddRange(movimentacaos);

            context.SaveChanges();

        }

    }
}
