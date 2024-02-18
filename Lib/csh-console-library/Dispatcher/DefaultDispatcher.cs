
namespace CommandApp.Dispatcher
{
    using Command;
    using Exceptions;

    public class DefaultDispatcher(ICommandCollection commands) : BaseDispatcher(commands)
    {
        protected override Type ExceptionType { get; } = typeof(CommandNotFound);
    }
}
