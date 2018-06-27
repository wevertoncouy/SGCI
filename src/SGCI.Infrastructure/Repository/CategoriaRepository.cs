using SGCI.ApplicationCore.Entity;
using SGCI.ApplicationCore.Interfaces.Repository;
using SGCI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SGCI.Infrastructure.Repository
{

    public class CategoriaRepository : EFRepository<Categoria>, ICategoriaRepository
    {

        public CategoriaRepository(GestaoCarteiraContext dbContext) : base(dbContext)
        {

        }
       



    }
}
