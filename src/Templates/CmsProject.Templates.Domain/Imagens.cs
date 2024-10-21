using CmsProject.Core.DomainObjects;
using System;

namespace CmsProject.Templates.Domain
{
    public class Imagens : Entity
    {
        public string Nome { get; private set; }

        public string CaminhoImagem { get; private set; }

        public bool Status { get; private set; }

        public string Conteudo { get; private set; }

        public Pagina Pagina { get; private set; }

        public bool EhArquivoFisico { get; private set; }

        protected Imagens() { }
        
        public Imagens(string Nome, string CaminhoImagem, bool Status, string Conteudo, bool EhArquivoFisico)
        {
            Nome = Nome;
            CaminhoImagem = CaminhoImagem;
            Status = Status;
            Conteudo = Conteudo;
            EhArquivoFisico = EhArquivoFisico;
        }
        
    }
}