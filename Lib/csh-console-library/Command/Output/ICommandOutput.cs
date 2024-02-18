namespace CommandApp.Command
{
    public interface ICommandOutput
    {
        string Display(ICommand command);
    }
}