using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGCI.ApplicationCore.Entity
{
    public class Lancamento
    {


        public Lancamento()
        {

        }

        [Key]
        public int LancamentoId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataLancamento { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }//fk

        [ForeignKey("Conta")]
        public int ContaId { get; set; }//fk

        public decimal Valor { get; set; }

        public string Descricao { get; set; }

        public Categoria Categoria { get; set; }

        public Conta Conta { get; set; }

        public StatusLancamento StatusLancamento { get; set; }


    
    }
}
