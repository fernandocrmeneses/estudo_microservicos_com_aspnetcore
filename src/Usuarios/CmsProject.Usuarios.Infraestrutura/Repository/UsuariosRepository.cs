using CmsProject.Core.Data;
using CmsProject.Usuarios.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Usuarios.Infraestrutura.Repository
{
    public class UsuariosRepository : IUsuariosRepository
    {
        public readonly UsuariosContexts _context;

        public UsuariosRepository(UsuariosContexts context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;


        public void Adicionar(Domain.Usuarios usuarios)
        {
            _context.Usuarios.Add(usuarios);
        }

        public void Atualizar(Domain.Usuarios usuarios)
        {
            _context.Update(usuarios);
        }

        public async Task<Domain.Usuarios> ObterPorId(Guid id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<IEnumerable<Domain.Usuarios>> ObterTodos()
        {
            return await _context.Usuarios.AsNoTracking().ToListAsync();
        }

        public void Desativar(Guid id)
        {
            _context.Usuarios.FindAsync(id).Result.Desativar();
        }

        public void Ativar(Guid id)
        {
            _context.Usuarios.FindAsync(id).Result.Ativar();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Deletar(Domain.Usuarios usuarios)
        {
            var entidade = _context.Usuarios.FindAsync(usuarios.Id);
            _context.Usuarios.Remove(entidade.Result);
        }

       

       
    }
}
