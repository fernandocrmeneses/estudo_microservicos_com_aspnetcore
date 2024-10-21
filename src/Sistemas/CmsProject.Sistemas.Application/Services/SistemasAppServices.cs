//using CmsProject.Sistemas.Domain;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using AutoMapper;

//namespace CmsProject.Sistemas.Application.Services
//{
//    public class SistemasAppServices : ISistemasAppServices
//    {
//        private readonly ISistemasRepository _sistemasRepository;
//        private readonly IMapper _mapper;

//        public SistemasAppServices(ISistemasRepository sistemaRepository, IMapper mapper)
//        {
//            _sistemasRepository = sistemaRepository;
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
