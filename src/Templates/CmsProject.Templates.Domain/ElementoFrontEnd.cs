using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace CmsProject.Templates.Domain
{
    public class ElementoFrontEnd : Entity
    {
        public Guid IdPagina { get; private set; }
        public string CaminhoArquivo { get; private set; }
        public string Nome { get; private set; }
        public bool Status { get; private set; }
        public bool EhArquivoFisico { get; private set; }
        public int Workflow { get; private set; }
        public Pagina Pagina { get; private set; }
        public string Tipo { get; private set; }
        public string Conteudo { get; private set; }
        public ICollection<BackupElementoFrontEnd> BackupElementoFrontEnd { get; set; }
    }
}