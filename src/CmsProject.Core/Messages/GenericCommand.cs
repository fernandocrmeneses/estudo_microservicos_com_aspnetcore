using CmsProject.Core.Communication.GenericsCommunication;
using CmsProject.Core.Communication.Mediator;
using CmsProject.Core.DomainObjects;
using CmsProject.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CmsProject.Core.Messages
{
    //public class GenericCommand<TEntity> : IRequestHandler<AddCommand<TEntity>, TRequest> where TEntity : Entity
    //{
    //    private readonly Repository<TEntity> _repository;
    //    public readonly IMediatorHandler _mediatorHandler;
    //    private readonly TEntity entity;

    //    public GenericCommand(Repository<TEntity> repository, IMediatorHandler mediatorHandler)
    //    {
    //        _repository = repository;
    //        _mediatorHandler = mediatorHandler;
    //        //entity = objeto;
    //    }

    //    public async Task<bool> Handle(AddCommand<TEntity> request, CancellationToken cancellationToken)
    //    {
    //        _repository.Adicionar(entity);
    //        if (request.GetType().Name.Contains("Add"))
    //        {
    //            _repository.Adicionar(entity);
    //        }

    //        throw new NotImplementedException();
    //    }
    //}
}
