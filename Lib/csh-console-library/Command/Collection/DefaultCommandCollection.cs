namespace CommandApp.Command
{
    public class DefaultCommandCollection : BaseCommandCollection
    {
        public override List<ICommand> Commands { get; } = [
            new QuitCommand(),
    ];
    }
}