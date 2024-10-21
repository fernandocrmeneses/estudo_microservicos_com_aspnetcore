using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Sistemas.Domain
{
    public class Sistemas : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public bool Status { get; private set; }
        public Guid IdUsuario { get; private set; }

        public Sistemas(string Nome, bool Status, Guid IdUsuario)
        {
            Nome = Nome;
            Status = Status;
            IdUsuario = IdUsuario;
        }

        public void Ativar() => Status = true;
        public void Desativar() => Status = false;

    }
}
