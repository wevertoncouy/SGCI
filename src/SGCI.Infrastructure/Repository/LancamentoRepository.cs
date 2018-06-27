using SGCI.ApplicationCore.Entity;
using SGCI.ApplicationCore.Interfaces.Repository;
using SGCI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SGCI.Infrastructure.Repository
{

    public class LancamentoRepository : EFRepository<Lancamento>, ILancamentoRepository
    {

        public LancamentoRepository(GestaoCarteiraContext dbContext) : base(dbContext)
        {

        }

        //public Lancamento ObterCategoria(int categoriaId)
        //{
        //    //return Buscar(x => x.(p => p.Categoria == categoriaId))
        //    //    .FirstOrDefault();
        //}



     
    } 

}
