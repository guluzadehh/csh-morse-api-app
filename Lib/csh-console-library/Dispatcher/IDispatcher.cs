namespace CommandApp.Dispatcher
{
    using Command;
    using App;

    public interface IDispatcher
    {
        ICommandCollection Commands { get; }
        void Dispatch(string value, IApp app);
    }
}
