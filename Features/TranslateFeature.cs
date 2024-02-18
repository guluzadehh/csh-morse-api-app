using System.Text.Json;
using CommandApp.Exceptions;

namespace MorseTranslateApp
{
    public class TranslateFeature : BaseFeature
    {
        public override void Run()
        {
            string text = App.Input.Get("Enter text");

            App.Output.Write("[i] Sending request to translate...");

            string uri = $"https://api.funtranslations.com/translate/morse.json?text={Uri.EscapeDataString(text)}";

            HttpClient client = new();

            client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");

            using Stream stream = client.GetStreamAsync(uri).Result;
            Translation translation = JsonSerializer.Deserialize<Translation>(stream);

            if (translation == null || translation.Success.Total != 1)
            {
                throw new BaseException("Something went wrong while translating");
            }

            History.Add(translation);

            SendResponse(Helpers.TransformTranslation(translation));
        }
    }
}