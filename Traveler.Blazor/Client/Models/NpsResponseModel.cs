using System.Text.Json.Serialization;

namespace Traveler.Blazor.Client.Models
{
    public class NpsResponseModel<T>
    {
        public NpsResponseModel() { }

        [JsonPropertyName("total")]
        public string? Total { get; set; }

        [JsonPropertyName("limit")]
        public string? Limit { get; set; }

        [JsonPropertyName("start")]
        public string? Start { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }

    }
}
