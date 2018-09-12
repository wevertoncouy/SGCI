using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGCI.ApplicationCore.Entity
{
    public class Movimentacao
    {

        public Movimentacao()
        {



        }

        public int MovimentacaoId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
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
