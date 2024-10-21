//using AutoMapper;
//using CmsProject.Usuarios.Application.ViewModels;
//using CmsProject.Usuarios.Domain;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace CmsProject.Usuarios.Application.Services
//{
//    public class SistemasAppServices : ISistemasAppServices
//    {
//        private readonly IUsuariosRepository _usuariosRepository;
//        private readonly IMapper _mapper;

//        public SistemasAppServices(IUsuariosRepository usuarioRepository, IMapper mapper)
//        {
//            _usuariosRepository = usuarioRepository;
//            _mapper = mapper;
//        }



//        public void Dispose()
//        {
//            _usuariosRepository?.Dispose();
//        }

//        public async Task<SistemasViewModel> ObterSistemasPorId(Guid Id)
//        {
//            var sistemasEntidade = await _usuariosRepository.ObterSistemaPorId(Id);
//            return _mapper.Map<SistemasViewModel>(sistemasEntidade);
//        }

//        public async Task<SistemasViewModel> ObterTodosSistemas()
//        {
//            var entidade = await _usuariosRepository.ObterTodos();
//            return _mapper.Map<SistemasViewModel>(entidade);
//        }
//    }
//}
