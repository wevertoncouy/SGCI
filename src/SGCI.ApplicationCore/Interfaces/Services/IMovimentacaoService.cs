using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SGCI.ApplicationCore.Entity;

namespace SGCI.ApplicationCore.Interfaces.Services
{
    public interface IMovimentacaoService
    {
        Movimentacao Adicionar(Movimentacao entity);

        void Atualizar(Movimentacao entity);

        IEnumerable<Movimentacao> ObterTodos();

        Movimentacao ObterPorId(int id);

        IEnumerable<Movimentacao> Buscar(Expression<Func<Movimentacao, bool>> predicado);

        void Remover(Movimentacao entity);
        Movimentacao RegistarMovimentacao(Movimentacao movimentacao);
    }
}
