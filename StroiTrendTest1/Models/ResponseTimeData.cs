using System.Text.Json.Serialization;

namespace StroiTrendTest1.Models
{
    public class ResponseTimeData
    {
        public int Count { get; set; } = 0;

        [JsonPropertyName("response_time")]
        public decimal ResponseTime { get; set; } = 0;
    }
}
