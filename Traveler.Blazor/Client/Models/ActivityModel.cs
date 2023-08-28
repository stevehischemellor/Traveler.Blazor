using System.Text.Json.Serialization;

namespace Traveler.Blazor.Client.Models
{
    public class ActivityModel
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
