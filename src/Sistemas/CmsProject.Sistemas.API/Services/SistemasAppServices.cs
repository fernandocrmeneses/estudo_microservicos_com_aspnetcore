using AutoMapper;
using CmsProject.Sistemas.API.ViewModel;
using CmsProject.Sistemas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Sistemas.API.Services
{
    public class SistemasAppServices : ISistemasAppServices
    {
        private readonly ISistemasRepository _sistemasRepository;
        private readonly IMapper _mapper;

        public SistemasAppServices(ISistemasRepository sistemaRepository, IMapper mapper)
        {
            _sistemasRepository = sistemaRepository;
            _mapper = mapper;
        }

        public void AdicionarSistema(SistemasViewModel sistemas)
        {
            //var usuarioObject = _mapper.Map<Domain.Sistemas>(sistemas);
            _sistemasRepository.Adicionar(_mapper.Map<Domain.Sistemas>(sistemas));
            _sistemasRepository.UnitOfWork.Commit();
        }

        public Task AtivarSistema(SistemasViewModel sistemas)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarSistema(SistemasViewModel sistemas)
        {
            throw new NotImplementedException();
        }

        public void DeletarSistema(SistemasViewModel sistemas)
        {
            throw new NotImplementedException();
        }

        public Task DesativarSistema(SistemasViewModel sistemas)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _sistemasRepository?.Dispose();
        }

        public async Task<SistemasViewModel> ObterSistemasPorId(Guid Id)
        {
            var sistemasEntidade = await _sistemasRepository.ObterPorId(Id);
            return _mapper.Map<SistemasViewModel>(sistemasEntidade);
        }

        public async Task<SistemasViewModel> ObterTodosSistemas()
        {
            var entidade = await _sistemasRepository.ObterTodos();
            return _mapper.Map<SistemasViewModel>(entidade);
        }
    }
}
