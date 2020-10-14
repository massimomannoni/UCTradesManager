using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TradeManager.Application.Configuration.Processing;

namespace TradeManager.Application.Trades.IntegrationHandlers
{
    public class TradeRegisteredNotificationHandler : INotificationHandler<TradeRegisteredNotification>
    {
        private readonly ICommandsScheduler _commandsScheduler;

        public TradeRegisteredNotificationHandler(ICommandsScheduler commandsScheduler)
        {
            _commandsScheduler = commandsScheduler;
        }

        public async Task Handle(TradeRegisteredNotification notification, CancellationToken cancellationToken)
        {
            // do something here.

            await _commandsScheduler.EnqueueAsync();
        }
    }
}