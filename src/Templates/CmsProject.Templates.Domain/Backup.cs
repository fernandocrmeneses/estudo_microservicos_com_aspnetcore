using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Domain
{
    public class Backup
    {
        public DateTime Data { get; private set; }

        public Guid IdFile { get; private set; }

        public string Tipo { get; private set; }

        public string CaminhoFile { get; private set; }

        public string Conteudo { get; private set; }

        public bool Status { get; private set; }
        
        public bool SalvamentoExterno { get; private set; }

        public Backup(DateTime Data, Guid IdFile, string Tipo, string CaminhoFile, string Conteudo, bool Status, bool SalvamentoExterno)
        {
            this.CaminhoFile = CaminhoFile;
            this.Conteudo = Conteudo;
            this.IdFile = IdFile;
            this.Status = Status;
            this.Tipo = Tipo;
            this.SalvamentoExterno = SalvamentoExterno;
        }
    }
}
