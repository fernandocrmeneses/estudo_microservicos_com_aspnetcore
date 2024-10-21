using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Usuarios.Domain
{
    public class Sistemas : Entity
    {
        public string Nome { get; private set; }
        public bool Status { get; private set; }

        public Sistemas(string Nome, bool Status)
        {
            Nome = Nome;
            Status = Status;
        }

        public void Ativar() => Status = true;
        public void Desativar() => Status = false;

    }

}
