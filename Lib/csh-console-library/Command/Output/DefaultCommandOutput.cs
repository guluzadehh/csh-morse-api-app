namespace CommandApp.Command
{
    public class DefaultCommandOutput : ICommandOutput
    {
        public string Display(ICommand command)
        {
            return $"{command.Value} - {command.Description}";
        }
    }
}
