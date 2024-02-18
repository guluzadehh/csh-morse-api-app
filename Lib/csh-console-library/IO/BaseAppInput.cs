namespace CommandApp.IO
{
    public abstract class BaseAppInput : IAppInput
    {
        public abstract string InputText { get; }

        public abstract string QuitCommand { get; }

        public string Get(string? infoText = null)
        {
            Console.SetCursorPosition(0, Console.WindowHeight);
            if (infoText != null)
            {
                Console.Write(infoText);
            }

            Console.Write(InputText + " ");

            string? input = Console.ReadLine();
            Console.Clear();

            if (input == null)
            {
                throw new Exceptions.BaseException("Input can't be null");
            }

            ValidateInput(input);

            return input;
        }

        protected virtual void ValidateInput(string input)
        {
            if (input.Equals(QuitCommand, StringComparison.CurrentCultureIgnoreCase))
            {
                throw new Exceptions.QuitInputRead();
            }
        }
    }
}
