
using System.Threading.Tasks;

namespace TradeManager.Application.Models.Trades
{
    public interface ITradeRepository
    {
        Task Create(Trade trade);

        // write here other operations
    }
}
