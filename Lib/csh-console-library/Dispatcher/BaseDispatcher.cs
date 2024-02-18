namespace CommandApp.Dispatcher
{
    using Command;
    using App;

    public abstract class BaseDispatcher(ICommandCollection commands) : IDispatcher
    {
        public ICommandCollection Commands { get; } = commands;
        protected abstract Type ExceptionType { get; }

        public void Dispatch(string value, IApp app)
        {
            FindCommand(value).Execute(app);
        }

        protected ICommand FindCommand(string value)
        {
            foreach (ICommand command in Commands)
            {
                if (command.Value == value)
                {
                    return command;
                }
            }

            throw (Exception)Activator.CreateInstance(ExceptionType, value)!;
        }
    }
}