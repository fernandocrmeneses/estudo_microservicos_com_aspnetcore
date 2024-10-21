﻿using System.Threading.Tasks;
using CmsProject.Core.Messages;
using CmsProject.Core.Messages.CommonMessages.DomainEvents;
using CmsProject.Core.Messages.CommonMessages.Notifications;
using FluentValidation.Results;

namespace CmsProject.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}