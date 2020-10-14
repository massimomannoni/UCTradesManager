using System.Threading.Tasks;
using TradeManager.Application.Database;

namespace TradeManager.Application.Models.Trades
{
    public class TradeRespository : ITradeRepository
    {

        private readonly UpsLightContext _Context;

        public TradeRespository(UpsLightContext context)
        {
            _Context = context;
        }
        public async Task Create(Trade trade)
        {
            await _Context.Trade.AddAsync(trade);
        }

    }
}
