namespace CommandApp.Feature
{
    using App;

    public interface IFeature
    {
        IApp App { get; set; }
        void Run();
    }
}