using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CmsProject.Core.DomainObjects;

namespace CmsProject.Core.Data
{
    public interface IRepository<T> : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }

        void Adicionar(T contextModel);
        void Atualizar(T contextModel);
        void Deletar(T contextModel);
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(Guid id);
        void Ativar(Guid id);
        void Desativar(Guid id);
    }
}