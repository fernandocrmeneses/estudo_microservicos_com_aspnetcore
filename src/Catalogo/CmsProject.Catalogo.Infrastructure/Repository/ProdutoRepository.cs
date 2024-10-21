using CmsProject.Catalogo.Domain;
using CmsProject.Catalogo.Domain.Interfaces;
using CmsProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Catalogo.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Adicionar(Produtos contextModel)
        {
            throw new NotImplementedException();
        }

        public void Ativar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Produtos contextModel)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Produtos contextModel)
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

        public Task<Produtos> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produtos>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
