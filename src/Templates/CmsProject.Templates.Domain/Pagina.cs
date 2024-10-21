using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Domain
{
    public class Pagina : Entity, IAggregateRoot
    {
        public Guid IdUsuario { get; set; }

        public string Header { get; private set; }

        public string Menu { get; private set; }

        public string Body { get; private set; }

        public string Footer { get; private set; }

        public string Nome { get; private set; }

        public string Categoria { get; private set; }

        public ICollection<ElementoFrontEnd> ElementoFrontEnd { get; private set; }

        public bool Status { get; private set; }

        public int WorkFlow { get; private set; }

        public ICollection<Imagens> Imagens { get; private set; }

        public ICollection<BackupPagina> BackupPagina { get; set; }

        public Templates Templates { get; private set; }

        protected Pagina() { }
        public Pagina(string Header, string Menu, string Body, string Footer, string Nome, string Categoria, string Css, string Javascript, bool Status, int WorkFlow)
        {
            this.Header = Header;
            this.Menu = Menu;
            this.Body = Body;
            this.Footer = Footer;
            this.Nome = Nome;
            this.Status = Status;
            this.WorkFlow = WorkFlow;
            Validar();
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Header, "O campo Header não pode estar vazio");
            Validacoes.ValidarSeVazio(Menu, "O campo Menu não pode estar vazio");
            Validacoes.ValidarSeVazio(Body, "O campo Body não pode estar vazio");
            Validacoes.ValidarSeVazio(Footer, "O campo Footer/Rodapé não pode estar vazio");
            Validacoes.ValidarSeNulo(Nome, "O campo Nome não pode estar null");
            Validacoes.ValidarSeNulo(Status, "O campo Status não pode estar null");
            Validacoes.ValidarSeNulo(WorkFlow, "O campo Workflow não pode estar null");
        }
    }
}
