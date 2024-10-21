using AutoMapper;
using CmsProject.Auth.Api.ViewModels;
using CmsProject.Usuarios.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Auth.Api.Services
{
    public interface IUsuariosAppServices
    {
        //public Task AdicionarSistema(SistemasViewModel sistemas);
        //public Task AtualizarSistemas(SistemasViewModel sistemas);
        //public Task<SistemasViewModel> ObterSistemaPorId(Guid id);
        //public Task<IEnumerable<UsuariosViewModel>> ObterPorSistema(Guid idSistema);

        public Task<IdentityResult> AdicionarUsuario(UsuariosViewModel usuarios);

        public Task AtualizarUsuario(UsuariosViewModel usuarios);

        public Task<UsuariosViewModel> ObterPorId(Guid id);

        public Task<IEnumerable<UsuariosViewModel>> ObterTodos();

        public Task DesativarUsuario(Guid id);

        public Task AtivarUsuario(Guid id);

        public Task DeletarUsuario(UsuariosViewModel usuarios);

    }
}
