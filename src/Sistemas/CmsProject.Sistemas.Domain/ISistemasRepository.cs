using CmsProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Sistemas.Domain
{
    public interface ISistemasRepository : IRepository<Domain.Sistemas>
    {

        #region sistema
        //void AdicionarSistema(Sistemas sistemas);
        //void AtualizarSistemas(Sistemas sistemas);
        //void AtivarSistemas(Guid id);
        //void DesativarSistemas(Guid id);
        //void DeletarSistema(Sistemas sistema);
        #endregion sistema

        public void Dispose();
    }
}
