using CmsProject.Core.DomainObjects;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CmsProject.Usuarios.Domain
{
    public class Usuarios : IdentityUser, IAggregateRoot
    {
        //[Key]
        //public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string CPF_CNPJ { get; private set; }
        public bool Ativo { get; private set; }
        public string Status { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataCancelamento { get; private set; }
        public DateTime DataRetorno { get; private set; }
        public int TipoUsuario { get; private set; }
        public Guid IdSistema { get; private set; }
        //public string Email { get; private set; }
        //public Guid IdAspnetUsers { get; private set; }


        public Usuarios() { }
        public Usuarios(string Nome, string SobreNome, string CPF_CNPJ, bool Ativo, DateTime DataCriacao, DateTime DataCancelamento, DateTime DataRetorno, int TipoUsuario, string Status, Guid IdSistema, string Email)
        {
            this.Nome = Nome;
            this.SobreNome = SobreNome;
            this.Ativo = Ativo;
            this.DataCriacao = DataCriacao;
            this.DataCancelamento = DataCancelamento;
            this.DataRetorno = DataRetorno;
            this.CPF_CNPJ = CPF_CNPJ;
            this.TipoUsuario = TipoUsuario;
            this.Status = Status;
            this.IdSistema = IdSistema;
            this.Email = Email;
            Validar();
        }

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome não pode estar vazio");
            Validacoes.ValidarSeVazio(SobreNome, "O campo Sobrenome não pode estar vazio");
            Validacoes.ValidarSeVazio(Status, "O campo CPF/CNPJ não pode estar vazio");
            //Validacoes.ValidarSeDiferenteInteiro(CPF_CNPJ, "O campo CPF/CNPJ não pode estar vazio");
            Validacoes.ValidarSeNulo(CPF_CNPJ, "O campo CPF/CNPJ não pode estar null");
        }
    }
}
