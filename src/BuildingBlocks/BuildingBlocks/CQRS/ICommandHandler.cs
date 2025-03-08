

using MediatR;

namespace BuildingBlocks.CQRS
{
    //if there is no response from the command object
    public interface ICommandHandler<in TCommand>:ICommandHandler<TCommand,Unit>
        where TCommand :ICommand<Unit>
    {

    }

    //when command returns response
    public interface ICommandHandler<in TCommand, TResponse> 
        : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
        where TResponse: notnull
    {

    }
}
