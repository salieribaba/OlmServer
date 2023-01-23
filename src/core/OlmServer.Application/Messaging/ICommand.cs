using MediatR;

namespace OlmServer.Application.Messaging
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
