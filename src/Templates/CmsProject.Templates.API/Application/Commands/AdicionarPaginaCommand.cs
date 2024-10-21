using System;
using System.Collections.Generic;
using System.Text;
using CmsProject.Core.Messages;
using CmsProject.Templates.API.Application.DTO;
using CmsProject.Templates.API.Application.Commands.AbstractValidators;
using CmsProject.Templates.Application.ViewModels;
using CmsProject.Templates.Domain;

namespace CmsProject.Templates.API.Application.Commands
{
    public class AdicionarPaginaCommand : Command
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

        public List<ElementoFrontEndDTO> ElementoFrontEnd { get; set; }

        public bool Status { get; set; }

        public int WorkFlow { get; set; }

        public List<ImagensDTO> Imagens { get; set; }

        //public ICollection<BackupPagina> BackupPagina { get; set; }

        public Guid TemplatesId { get; set; }

        // public Imagens Imagens { get; private set; }

        public AdicionarPaginaCommand(Guid Id, Guid IdUsuario, DateTime DataCriacao, DateTime DataAtualizacao,
            string Header, string Menu, string Body, string Footer, string Nome, string Categoria, List<ElementoFrontEndDTO> listaElementoFrontEnd, 
            List<ImagensDTO> Imagens, Guid TemplatesId, bool Status, int WorkFlow)
        {
            Id = Id;
            IdUsuario = IdUsuario;
            DataCriacao = DataCriacao;
            DataAtualizacao = DataAtualizacao;
            Header = Header;
            Menu = Menu;
            Body = Body;
            Footer = Footer;
            Nome = Nome;
            Categoria = Categoria;
            listaElementoFrontEnd = listaElementoFrontEnd;
            Status = Status;
            WorkFlow = WorkFlow;
            Imagens = Imagens;
            TemplatesId = TemplatesId;
        }

        public bool EhValido()
        {
            ValidationResult = new AdicionarPaginaValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
