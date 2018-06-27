using SGCI.ApplicationCore.Entity;
using SGCI.ApplicationCore.Interfaces.Repository;
using SGCI.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGCI.ApplicationCore.Services
{
    public class LancamentoService : ILancamentoService

    {

        private readonly ILancamentoRepository _lancamentoRepository;

        public LancamentoService(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }

        public Lancamento Adicionar(Lancamento entity)
        {
            //Tudo : Adicionar regra de negócio           
            return _lancamentoRepository.Adicionar(entity);
        }

        public void Atualizar(Lancamento entity)
        {
            _lancamentoRepository.Atualizar(entity);
        }

        public IEnumerable<Lancamento> Buscar(Expression<Func<Lancamento, bool>> predicado)
        {
            return _lancamentoRepository.Buscar(predicado);
        }

        public Lancamento ObterPorId(int id)
        {
            return _lancamentoRepository.ObterPorId(id);
        }

        public IEnumerable<Lancamento> ObterTodos()
        {
            return _lancamentoRepository.ObterTodos();
        }

        public void Remover(Lancamento entity)
        {
            _lancamentoRepository.Remover(entity);
        }
    }
}
