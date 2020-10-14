using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeManager.Application.Trades.CreateTrade
{
    public class CreateTradeRequest : IRequest<Guid>
    {

        public string Name { get; set; }

        public int Type { get; set; }

        public string Details { get; set; }

        public Guid SchemaId { get; set; }

        public Guid PortfolioId { get; set; }

        public CreateTradeRequest(string name, int type, string details, Guid schemaId, Guid portfolioId)
        {
            Name = name;
            Type = type;
            Details = details;
            SchemaId = schemaId;
            PortfolioId = portfolioId;
        }
    }
}
