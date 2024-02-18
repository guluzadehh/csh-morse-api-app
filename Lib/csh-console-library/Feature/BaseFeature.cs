namespace CommandApp.Feature
{
    using App;

    public abstract class BaseFeature : IFeature
    {
        public IApp App { get; set; }

        public abstract void Run();

        protected void SendResponse(string data)
        {
            App.Output.WriteAndWait(data);
        }
    }
}
