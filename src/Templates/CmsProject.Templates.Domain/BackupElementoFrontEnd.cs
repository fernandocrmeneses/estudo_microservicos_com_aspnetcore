using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Domain
{
    public class BackupElementoFrontEnd : Entity
    {

        public ElementoFrontEnd ElementoFrontEnd { get; private set; }
        public Guid IdElementoFrontEnd { get; private set; }

        //E.F.
        protected BackupElementoFrontEnd() { }

        public BackupElementoFrontEnd(ElementoFrontEnd elementoFrontEnd, Guid idElementoFrontEnd)
        {
            IdElementoFrontEnd = idElementoFrontEnd;
            ElementoFrontEnd = elementoFrontEnd;
        }
    }
}
