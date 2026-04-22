using MediatR;

namespace BuildingBlocks.CQRS;

// Si no hay respuesta (TReponse) del objeto COMMNAD, usamos esta interface, en cualquier otro caso con respuesta, la 2 interface...
public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit> 
    where TCommand : ICommand<Unit>
{ 
}

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> 
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{
}