using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using CmsProject.Core.Messages;
using CmsProject.Core.Communication.GenericsCommunication;
using CmsProject.Core.DomainObjects;
using CmsProject.Core.Communication.Mediator;
using CmsProject.Core.Repositories;
using CmsProject.Core.Data;
using System.Threading.Tasks;
using System.Threading;

namespace CmsProject.Core.Extensions
{
    public class GenericCommandHandler<T, TEntity> : Command
        where T : Command
        where TEntity : Entity
    {
        private readonly Repository<TEntity> _repository;
        private readonly IMediatorHandler _mediatorHandler;


        public GenericCommandHandler(Repository<TEntity> repository, IMediatorHandler mediatorHandler)
        {
            _repository = repository;
            _mediatorHandler = mediatorHandler;
        }

        //public async Task<bool> Handle(GenericCommand<TEntity> message, CancellationToken cancellationToken)
        //{
        //    return await _repository.UnitOfWork.Commit();
        //}
    }


}
