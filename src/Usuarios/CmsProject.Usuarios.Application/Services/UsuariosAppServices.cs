using AutoMapper;
using CmsProject.Usuarios.Application.ViewModels;
using CmsProject.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Usuarios.Application.Services
{
    public class UsuariosAppServices : IUsuariosAppServices
    {
        private readonly IUsuariosRepository _usuariosRepository;
        private readonly IMapper _mapper;
        public UsuariosAppServices(IUsuariosRepository usuariosRepository, IMapper mapper)
        {
            _mapper = mapper;
            _usuariosRepository = usuariosRepository;
        }

        public async Task AdicionarUsuario(UsuariosViewModel usuarios)
        {
            var usuarioObject = _mapper.Map<Domain.Usuarios>(usuarios);
            _usuariosRepository.Adicionar(usuarioObject);
            await _usuariosRepository.UnitOfWork.Commit();
        }
       

        public async Task AtualizarUsuario(UsuariosViewModel usuarios)
        {
            try
            {
                _usuariosRepository.Atualizar(_mapper.Map<Domain.Usuarios>(usuarios));
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
            _usuariosRepository.Deletar(_mapper.Map<Domain.Usuarios>(usuarios));
           await _usuariosRepository.UnitOfWork.Commit();
        }
    }
}
