using CmsProject.Usuarios.Application.ViewModels;
using CmsProject.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Usuarios.Application.Services
{
    public interface IUsuariosAppServices : IDisposable
    {
        //public Task AdicionarSistema(SistemasViewModel sistemas);
        //public Task AtualizarSistemas(SistemasViewModel sistemas);
        //public Task<SistemasViewModel> ObterSistemaPorId(Guid id);
        //public Task<IEnumerable<UsuariosViewModel>> ObterPorSistema(Guid idSistema);

        public Task AdicionarUsuario(UsuariosViewModel usuarios);

        public Task AtualizarUsuario(UsuariosViewModel usuarios);

        public Task<UsuariosViewModel> ObterPorId(Guid id);

        public Task<IEnumerable<UsuariosViewModel>> ObterTodos();

        public Task DesativarUsuario(Guid id);

        public Task AtivarUsuario(Guid id);

        public Task DeletarUsuario(UsuariosViewModel usuarios);

    }
}
