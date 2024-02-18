namespace CommandApp.Command
{
    public interface ICommandCollection : IEnumerable<ICommand>
    {
        List<ICommand> Commands { get; }
        void Register(ICommand command);
    }
}
