namespace CommandApp.Command
{
    using App;

    public class QuitCommand : ICommand
    {
        public string Value { get; } = "quit";

        public string Description { get; } = "Quit app";

        public void Execute(IApp app)
        {
            app.Running = false;
        }
    }
}
