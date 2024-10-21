using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Application.ViewModels
{
    public class ImagensViewModel
    {
        public string Nome { get; private set; }

        public string CaminhoImagem { get; private set; }

        public bool Status { get; private set; }

        public string Conteudo { get; private set; }

        public bool EhArquivoFisico { get; private set; }
    }
}
