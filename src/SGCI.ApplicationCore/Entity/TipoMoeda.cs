using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGCI.ApplicationCore.Entity
{
    public enum TipoMoeda
    {
        [Display(Name = "BRL")]
        Real = 1,
        [Display(Name = "USD")]
        Dolar = 2,
        [Display(Name = "EUR")]
        Euro = 3,
        [Display(Name = "GBP")]
        LibraEsterlina = 4,
    }
}
