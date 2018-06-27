using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGCI.ApplicationCore.Entity
{
    public enum TipoMovimentacao
    {
        [Display(Name = "Depósito")]
        Deposito = 1,
        [Display(Name = "Saque")]
        Saque = 2,
    }
}
