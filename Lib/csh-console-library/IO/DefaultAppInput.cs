namespace CommandApp.IO
{
    public class DefaultAppInput : BaseAppInput
    {
        public override string InputText { get; } = ":";
        public override string QuitCommand { get; } = "q!";

    }
}
