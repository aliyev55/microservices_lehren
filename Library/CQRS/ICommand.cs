using MediatR;
namespace Library.CQRS
{
    public interface ICommand : ICommand<Unit>;

    public interface ICommand<out TResponse> : IRequest<TResponse>;
}



