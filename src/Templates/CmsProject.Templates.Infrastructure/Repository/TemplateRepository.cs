using CmsProject.Core.Data;
using CmsProject.Core.DomainObjects;
using CmsProject.Core.Repositories;
using CmsProject.Templates.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Templates.Infrastructure.Repository
{
    public class TemplateRepository<T> : Repository<T> where T : Entity
    {
        public TemplateRepository(TemplateContext context) : base(context) { }

        

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

      

     
    }
}
