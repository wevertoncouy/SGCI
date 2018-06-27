using SGCI.ApplicationCore.Entity;
using SGCI.ApplicationCore.Interfaces.Repository;
using SGCI.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGCI.ApplicationCore.Services
{
    public class ContaService : IContaService
    {

        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public Conta Adicionar(Conta entity)
        {
            //Tudo : Adicionar regra de negócio           
            return _contaRepository.Adicionar(entity);
        }

        public void Atualizar(Conta entity)
        {
            _contaRepository.Atualizar(entity);
        }

        public IEnumerable<Conta> Buscar(Expression<Func<Conta, bool>> predicado)
        {
            return _contaRepository.Buscar(predicado);
        }

        public Conta ObterPorId(int id)
        {
            return _contaRepository.ObterPorId(id);
        }

        public IEnumerable<Conta> ObterTodos()
        {
            return _contaRepository.ObterTodos();
        }

        public void Remover(Conta entity)
        {
            _contaRepository.Remover(entity);
        }
    }
}
