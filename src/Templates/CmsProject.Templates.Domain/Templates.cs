using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Domain
{
    public class Templates : Entity
    {
        public string Nome { get; private set; }
        public int Status { get; private set; }
        public ICollection<Pagina> Pagina { get; private set; }

        //EF
        protected Templates() { }

        public Templates(string Nome, int Status)
        {
            Nome = Nome;
            Status = Status;
        }
    }
}
