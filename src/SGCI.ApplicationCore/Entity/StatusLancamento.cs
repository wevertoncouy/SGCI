using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGCI.ApplicationCore.Entity
{
   public enum StatusLancamento
    {
        [Display(Name = "Confirmado")]
        Confirmado = 1,
        [Display(Name = "Não Confirmado")]
        NaoConfirmado = 2,
        [Display(Name = "Indefinido")]
        Indefinido = 3
    }
}
