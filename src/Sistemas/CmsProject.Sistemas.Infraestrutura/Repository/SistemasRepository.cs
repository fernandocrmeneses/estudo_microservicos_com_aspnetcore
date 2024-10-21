using CmsProject.Core.Data;
using CmsProject.Sistemas.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Sistemas.Infraestrutura.Repository
{
    public class SistemasRepository : ISistemasRepository
    {
        public readonly SistemasContexts _context;
        public IUnitOfWork UnitOfWork => _context;
       
        public void Adicionar(Domain.Sistemas sistemas)
        {
            _context.Sistemas.Add(sistemas);
        }

        public void Ativar(Guid id)
        {
            _context.Sistemas.FindAsync(id).Result.Ativar();
        }

        public void Atualizar(Domain.Sistemas sistemas)
        {
            _context.Update(sistemas);
        }

        public void Desativar(Guid id)
        {
            _context.Sistemas.FindAsync(id).Result.Desativar();
        }

        public void Deletar(Domain.Sistemas sistemas)
        {
            _context.Sistemas.Remove(sistemas);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Domain.Sistemas>> ObterTodos()
        {
            return await _context.Sistemas.AsNoTracking().ToListAsync();
        }

        public async Task<Domain.Sistemas> ObterPorId(Guid id)
        {
            return await _context.Sistemas.FindAsync(id);
        }
    }
}
