using CmsProject.Core.Messages;
using CmsProject.Templates.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.API.Application.Commands
{
    public class AtualizarTemplateCommand : Command
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Status { get; private set; }
        public List<PaginaViewModel> Pagina { get; private set; }

        public AtualizarTemplateCommand(Guid id, string nome, int status, PaginaViewModel pagina = null)
        {
            Id = id;
            Nome = nome;
            Status = status;
        }
    }
}
