namespace MorseTranslateApp
{
    public static class Helpers
    {
        public static string TransformTranslation(Translation translation)
        {
            return $"\nText:\n\t{translation.Contents.Text}\n\nTranslate:\n{translation.Contents.Translated}\n";
        }
    }
}