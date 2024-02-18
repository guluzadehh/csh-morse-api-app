using CommandApp.Exceptions;

namespace MorseTranslateApp
{
    public abstract class BaseFeature : CommandApp.Feature.BaseFeature
    {
        public List<Translation> History
        {
            get
            {
                return (List<Translation>)(App.Context["history"] ?? throw new BaseException("App doesn't have `History` context"));
            }
        }
    }
}