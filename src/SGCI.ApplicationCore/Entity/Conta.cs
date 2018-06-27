using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.ApplicationCore.Entity
{
   public class Conta
    {

        public Conta()
        {



        }

        public int ContaId { get; set; }

        public int UsuarioId { get; set; }

        //public TipoConta TipoConta { get; set; }

        public string Nome { get; set; }

        public decimal Saldo { get; set; }

        public TipoMoeda TipoMoeda { get; set; }

        public DateTime DataConta { get; set; }

        public ICollection<Movimentacao> Movimentacaos { get; set; }

        public ICollection<Lancamento> Lancamentos { get; set; }

      
        public Usuario Usuario{ get; set; }
    }
}
