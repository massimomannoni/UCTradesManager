using System;
using System.Text.Json.Serialization;
using TradeManager.Application.Configuration.DomainEvents;
using TradeManager.Application.Customers.IntegrationHandlers;

namespace TradeManager.Application.Domain.Events
{
    public class DomainNotificationBase<T> : IDomainEventNotification<T> where T : IDomainEvent
    {
        private TradeRegisteredNotification domainEvent;

        [JsonIgnore]
        public T DomainEvent { get; }

        public Guid Id { get; }

        public DomainNotificationBase(T domainEvent)
        {
            Id = Guid.NewGuid();
            DomainEvent = domainEvent;
        }
    }
}