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
    public class UsuariosAppServices : IUsuariosAppServices
    {

        private readonly IUsuariosRepository _usuariosRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        

        public UsuariosAppServices(IUsuariosRepository usuariosRepository, UserManager<IdentityUser> userManager, IMapper mapper)
        {
            _mapper = mapper;
            _usuariosRepository = usuariosRepository;
            _userManager = userManager;
            
        }

        public async Task<IdentityResult> AdicionarUsuario(UsuariosViewModel usuarios)
        {
            return await _userManager.CreateAsync(_mapper.Map<Usuarios.Domain.Usuarios>(usuarios), usuarios.Senha);
        }



        public async Task AtualizarUsuario(UsuariosViewModel usuarios)
        {
            try
            {
                _usuariosRepository.Atualizar(_mapper.Map<Usuarios.Domain.Usuarios>(usuarios));
                await _usuariosRepository.UnitOfWork.Commit();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<UsuariosViewModel> ObterPorId(Guid id)
        {
            var usuariosDomain = await _usuariosRepository.ObterPorId(id);
            return _mapper.Map<UsuariosViewModel>(usuariosDomain);
        }



        public async Task<IEnumerable<UsuariosViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<UsuariosViewModel>>(await _usuariosRepository.ObterTodos());
        }

        public void Dispose()
        {
            _usuariosRepository?.Dispose();
        }

        public async Task DesativarUsuario(Guid id)
        {
            _usuariosRepository.Desativar(id);
            await _usuariosRepository.UnitOfWork.Commit();
        }

        public async Task AtivarUsuario(Guid id)
        {
            _usuariosRepository.Ativar(id);
            await _usuariosRepository.UnitOfWork.Commit();
        }

        public async Task DeletarUsuario(UsuariosViewModel usuarios)
        {
            _usuariosRepository.Deletar(_mapper.Map<Usuarios.Domain.Usuarios>(usuarios));
            await _usuariosRepository.UnitOfWork.Commit();
        }
    }
}
