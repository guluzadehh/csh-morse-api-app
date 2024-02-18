using CommandApp.Command;
using CommandApp.Feature;

namespace MorseTranslateApp
{
    public class TranslateCommand : BaseCommand
    {
        public override string Value { get; } = "t";
        public override string Description { get; } = "Translate text to morse alphabet";
        public override IFeature Feature { get; } = new TranslateFeature();
    }

    public class HistoryCommand : BaseCommand
    {
        public override string Value { get; } = "h";
        public override string Description { get; } = "See history";
        public override IFeature Feature { get; } = new HistoryFeature();
    }
}