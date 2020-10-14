using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeManager.Application.Domain.Trade;
using TradeManager.Application.Models.Trades;
using TradeManager.Domain.SeedWork;

namespace TradeManager.Application.Trades.CreateTrade
{
    public class CreateTradeRequestHandler : Entity, IRequestHandler<CreateTradeRequest, Guid> 
    {
        private readonly TradeRespository _tradeRepository;
        public CreateTradeRequestHandler(TradeRespository tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }
        public async Task<Guid> Handle(CreateTradeRequest request, CancellationToken cancellationToken)
        {

            var newTrade = new Trade(request.Name, request.Type, request.Details, request.SchemaId, request.PortfolioId);
            
            await _tradeRepository.Create(newTrade);

            AddDomainEvent(new TradeRegisteredEvent(newTrade.Id));

            return newTrade.Id;
        }

    }
}
