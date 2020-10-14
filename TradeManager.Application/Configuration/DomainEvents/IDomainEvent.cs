using System;
using MediatR;

namespace TradeManager.Application.Configuration.DomainEvents
{
    public interface IDomainEvent : INotification
    {
        DateTime OccurredOn { get; }
    }
}