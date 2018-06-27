using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGCI.ApplicationCore.Entity
{
    public class Movimentacao
    {

        public Movimentacao()
        {



        }

        public int MovimentacaoId { get; set; }

        public DateTime DataCadastro { get; set; }

        [ForeignKey("Conta")]
        public int ContaId { get; set; }

        //public string Tipo { get; set; }

        public decimal Valor { get; set; }

        //public string Descricao { get; set; }
        public TipoMovimentacao TipoMovimentacao { get; set; }


        public Conta Conta { get; set; }

    }
}
