using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Clientes.Domain
{
    public class Clientes : Entity
    {
        public Guid IdCliente { get; private set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string CPF { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataInatividade { get; private set; }
        //public int Endereco { get; set; }

        public Clientes(Guid IdCliente, string Nome, string SobreNome, string CPF, bool Ativo, DateTime DataCriacao, DateTime DataInatividade)
        {
            IdCliente = IdCliente;
            
            Nome = Nome;
            SobreNome = SobreNome;
            CPF = CPF;
            Ativo = Ativo;
            DataCriacao = DataCriacao;
            DataInatividade = DataInatividade;
            //Endereco { get; set; }
        }
    }
}
