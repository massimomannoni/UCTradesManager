using Newtonsoft.Json;
using System;
using TradeManager.Application.Domain.Events;
using TradeManager.Application.Domain.Trade;

namespace TradeManager.Application.Trades.IntegrationHandlers
{
    public class TradeRegisteredNotification : DomainNotificationBase<TradeRegisteredEvent>
    {
        public Guid TradeId { get; }

        public TradeRegisteredNotification(TradeRegisteredEvent domainEvent) : base(domainEvent)
        {
            TradeId = domainEvent.TradeId;
        }

        [JsonConstructor]
        public TradeRegisteredNotification(Guid tradeId) : base(null)
        {
            TradeId = tradeId;
        }
    }
}