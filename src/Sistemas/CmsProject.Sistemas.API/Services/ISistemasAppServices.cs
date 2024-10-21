using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Sistemas.API.Services
{
    public interface ISistemasAppServices : IDisposable
    {
        public void AdicionarSistema(ViewModel.SistemasViewModel sistemas);

        public Task AtualizarSistema(ViewModel.SistemasViewModel sistemas);

        public void DeletarSistema(ViewModel.SistemasViewModel sistemas);

        public Task DesativarSistema(ViewModel.SistemasViewModel sistemas);

        public Task AtivarSistema(ViewModel.SistemasViewModel sistemas);

        public Task<ViewModel.SistemasViewModel> ObterSistemasPorId(Guid Id);

        public Task<ViewModel.SistemasViewModel> ObterTodosSistemas();
    }
}
