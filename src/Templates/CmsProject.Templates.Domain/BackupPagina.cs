using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Domain
{
    public class BackupPagina : Entity
    {
        public Guid IdPagina { get; private set; }
        
        //E.F Relacionamento
        public Pagina Pagina { get; private set; }

        protected BackupPagina(){}
        
        public BackupPagina(Guid IdPagina, Pagina pagina)
        {
            Pagina = pagina;
            Validar();
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Pagina.Header, "Backup da Pagina - O campo Header não pode estar vazio");
            Validacoes.ValidarSeVazio(Pagina.Menu, "Backup da Pagina - O campo Menu não pode estar vazio");
            Validacoes.ValidarSeVazio(Pagina.Body, "Backup da Pagina - O campo Body não pode estar vazio");
            Validacoes.ValidarSeVazio(Pagina.Footer, "Backup da Pagina - O campo Footer/Rodapé não pode estar vazio");
            Validacoes.ValidarSeNulo(Pagina.Nome, "Backup da Pagina - O campo Nome não pode estar null");
            Validacoes.ValidarSeNulo(Pagina.Status, "Backup da Pagina - O campo Status não pode estar null");
            Validacoes.ValidarSeNulo(Pagina.WorkFlow, "Backup da Pagina - O campo Workflow não pode estar null");
        }

    }
}
