using System.Text.Json.Serialization;

namespace StroiTrendTest1.Models
{
    public class DurationData
    {
        public int Duration { get; set; } = 0;

        [JsonPropertyName("agents_chatting_duration")]
        public int AgentsChattingDuration { get; set; } = 0;
    }
}
