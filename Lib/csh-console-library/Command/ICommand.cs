namespace CommandApp.Command
{
    using App;

    public interface ICommand
    {
        string Value { get; }
        string Description { get; }

        void Execute(IApp app);
    }
}
