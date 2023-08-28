using System.Text.Json.Serialization;

namespace Traveler.Blazor.Client.Models
{
    public class ParkModel
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        [JsonPropertyName("parkCode")]
        public string? ParkCode { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("latitude")]
        public string? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string? Longitude { get; set; }

        [JsonPropertyName("latLong")]
        public string? LatLong { get; set; }

        [JsonPropertyName("activities")]
        public List<ActivityModel>? Activities { get; set; }

        [JsonPropertyName("states")]
        public string? States { get; set; }

    }
}
