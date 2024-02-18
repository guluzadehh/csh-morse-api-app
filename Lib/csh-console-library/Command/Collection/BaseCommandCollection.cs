using System.Collections;

namespace CommandApp.Command
{
    public class BaseCommandCollection : ICommandCollection
    {
        public virtual List<ICommand> Commands { get; } = [];
        public void Register(ICommand command)
        {
            Commands.Add(command);
        }

        public IEnumerator<ICommand> GetEnumerator()
        {
            return Commands.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Commands.GetEnumerator();
        }
    }
}