using CmsProject.Usuarios.Application.ViewModels;
using CmsProject.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Usuarios.Application.Services
{
    public interface ISistemasAppServices : IDisposable
    {
        public Task AdicionarSistema(SistemasViewModel sistemas);
        
        public Task AtualizarSistema(SistemasViewModel sistemas);

        public Task DeletarSistema(SistemasViewModel sistemas);

        public Task DesativarSistema(SistemasViewModel sistemas);

        public Task AtivarSistema(SistemasViewModel sistemas);

        public Task<SistemasViewModel> ObterSistemasPorId(Guid Id);

        public Task<SistemasViewModel> ObterTodosSistemas();
    }
}
