using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Application.ViewModels
{
    public class ElementoFrontEndViewModel
    {
        public Guid IdPagina { get; set; }
        public string CaminhoArquivo { get; set; }
        public string Nome { get; set; }
        public bool Status { get;  set; }
        public bool EhArquivoFisico { get;  set; }
        public int Workflow { get;  set; }
        public string Tipo { get;  set; }
        public string Conteudo { get;  set; }
    }
}
