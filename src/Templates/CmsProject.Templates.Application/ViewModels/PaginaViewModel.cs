using System;
using System.Collections.Generic;
using System.Text;


namespace CmsProject.Templates.Application.ViewModels
{
    public class PaginaViewModel
    {
        public Guid Id { get; set; }

        public Guid IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public string Header { get; set; }

        public string Menu { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public List<ElementoFrontEndViewModel> ElementoFrontEnd { get; set; }

        public bool Status { get; set; }

        public int WorkFlow { get; set; }

        public List<ImagensViewModel> Imagens { get; set; }

        //public ICollection<BackupPagina> BackupPagina { get; set; }

        public Guid TemplatesId { get; set; }

        // public Imagens Imagens { get; private set; }
    }
}
