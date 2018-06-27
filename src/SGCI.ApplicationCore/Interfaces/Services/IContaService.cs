using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGCI.ApplicationCore.Interfaces.Services
{
    public interface IContaService
    {
        Conta Adicionar(Conta entity);

        void Atualizar(Conta entity);

        IEnumerable<Conta> ObterTodos();

        Conta ObterPorId(int id);

        IEnumerable<Conta> Buscar(Expression<Func<Conta, bool>> predicado);

        void Remover(Conta entity);
    }
}
