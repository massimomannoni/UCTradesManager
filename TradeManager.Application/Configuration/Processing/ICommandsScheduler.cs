using System.Threading.Tasks;
using MediatR;
using TradeManager.Application.Configuration.Commands;

namespace TradeManager.Application.Configuration.Processing
{
    public interface ICommandsScheduler
    {
        Task EnqueueAsync<T>(ICommand<T> command);
    }
}