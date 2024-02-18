namespace MorseTranslateApp
{
    public class HistoryFeature : BaseFeature
    {
        public override void Run()
        {
            foreach (Translation translation in History)
            {
                App.Output.Write(Helpers.TransformTranslation(translation));
                App.Output.Write("#####################################");
            }

            App.Output.WriteAndWait("\n");
        }
    }
}