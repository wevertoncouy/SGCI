using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGCI.ApplicationCore.Interfaces.Services
{
   public interface ILancamentoService
    {
        Lancamento Adicionar(Lancamento entity);

        void Atualizar(Lancamento entity);

        IEnumerable<Lancamento> ObterTodos();

        Lancamento ObterPorId(int id);

        IEnumerable<Lancamento> Buscar(Expression<Func<Lancamento, bool>> predicado);

        void Remover(Lancamento entity);
    }
}
