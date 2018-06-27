using SGCI.ApplicationCore.Entity;
using SGCI.ApplicationCore.Interfaces.Repository;
using SGCI.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGCI.ApplicationCore.Services
{
    public class MovimentacaoService : IMovimentacaoService
    {

        private readonly IMovimentacaoRepository _movimentacaoRepository;

        public MovimentacaoService(IMovimentacaoRepository movimentacaoRepository)
        {
            _movimentacaoRepository = movimentacaoRepository;
        }

        public Movimentacao Adicionar(Movimentacao entity)
        {
            //Tudo : Adicionar regra de negócio           
            return _movimentacaoRepository.Adicionar(entity);
        }

        public void Atualizar(Movimentacao entity)
        {
            _movimentacaoRepository.Atualizar(entity);
        }

        public IEnumerable<Movimentacao> Buscar(Expression<Func<Movimentacao, bool>> predicado)
        {
            return _movimentacaoRepository.Buscar(predicado);
        }

        public Movimentacao ObterPorId(int id)
        {
            return _movimentacaoRepository.ObterPorId(id);
        }

        public IEnumerable<Movimentacao> ObterTodos()
        {
            return _movimentacaoRepository.ObterTodos();
        }

        public Movimentacao RegistarMovimentacao(Movimentacao movimentacao)
        {
            throw new NotImplementedException();
        }

        public void Remover(Movimentacao entity)
        {
            _movimentacaoRepository.Remover(entity);
        }
    }
}
