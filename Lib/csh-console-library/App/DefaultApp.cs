namespace CommandApp.App
{
    using Command;
    using Dispatcher;
    using IO;

    public class DefaultApp(ICommandCollection commands) : BaseApp
    {
        public override ICommandCollection Commands { get; } = commands;

        public override IDispatcher Dispatcher { get; } = new DefaultDispatcher(commands);

        public override ICommandOutput CommandOutput { get; } = new DefaultCommandOutput();

        public override IAppOutput Output { get; } = new IO.DefaultAppOutput();
        public override IAppInput Input { get; } = new IO.DefaultAppInput();

        public override Dictionary<string, object?> Context { get; } = [];

    }
}