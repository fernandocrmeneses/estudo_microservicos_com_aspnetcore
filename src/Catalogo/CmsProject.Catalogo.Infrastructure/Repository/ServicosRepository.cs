using CmsProject.Catalogo.Domain;
using CmsProject.Catalogo.Domain.Interfaces;
using CmsProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Catalogo.Infrastructure.Repository
{
    public class ServicosRepository : IServicosRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Adicionar(Servicos contextModel)
        {
            throw new NotImplementedException();
        }

        public void Ativar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Servicos contextModel)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Servicos contextModel)
        {
            throw new NotImplementedException();
        }

        public void Desativar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Servicos> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Servicos>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
