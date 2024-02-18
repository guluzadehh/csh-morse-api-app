namespace CommandApp.IO
{
    public abstract class BaseAppOutput : IAppOutput
    {
        public abstract string WaitText { get; }

        public void ClearAndWrite(string data)
        {
            Clear();
            Write(data);
        }

        public void Wait()
        {
            Write(WaitText);
            Console.ReadLine();
            Clear();
        }

        public void WriteAndWait(string data)
        {
            Write(data);
            Wait();
        }

        public void Write(string data)
        {
            Console.WriteLine(data);
        }

        public void WriteAt(string data, int x, int y)
        {
            if (x < 0 || y < 0) return;
            Console.SetCursorPosition(x, y);
            Write(data);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}