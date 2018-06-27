using SGCI.ApplicationCore.Entity;
using SGCI.ApplicationCore.Interfaces.Repository;
using SGCI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SGCI.Infrastructure.Repository
{

    public class ContaRepository : EFRepository<Conta>, IContaRepository
    {

        public ContaRepository(GestaoCarteiraContext dbContext) : base(dbContext)
        {

        }
        



    }
}
