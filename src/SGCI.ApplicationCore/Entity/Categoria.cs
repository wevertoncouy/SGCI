using System;
using System.Collections.Generic;

using System.Text;

namespace SGCI.ApplicationCore.Entity
{
   public class Categoria
    {
        public Categoria()
        {

        }

        public int CategoriaId { get; set; }

        public string Descriao { get; set; }

        public ICollection<Lancamento> Lancamentos { get; set; }


    }
}
