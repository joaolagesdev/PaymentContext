using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand // Só pode manipular um command
    {
        ICommandResult Handle(T command);
    }
}