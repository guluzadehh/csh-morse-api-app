namespace CommandApp.IO
{
    public interface IAppOutput
    {
        void WriteAndWait(string data);
        void ClearAndWrite(string data);
        void Wait();
        void Write(string data);
        void WriteAt(string data, int x, int y);
        void Clear();
    }
}