using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.ApplicationCore.Entity
{
    public class Usuario
    {

        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public ICollection<Conta> Contas { get; set; }
        //
    }
}
