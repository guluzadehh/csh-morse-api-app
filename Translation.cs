using System.Text.Json.Serialization;

namespace MorseTranslateApp
{
    public record class Translation(
        [property: JsonPropertyName("success")] Success Success,
        [property: JsonPropertyName("contents")] Contents Contents
    );

    public record class Success(
        [property: JsonPropertyName("total")] int Total
    );

    public record class Contents(
        [property: JsonPropertyName("translated")] string Translated,
        [property: JsonPropertyName("text")] string Text
    );
}