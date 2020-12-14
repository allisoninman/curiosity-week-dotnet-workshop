using System.Text.Json.Serialization;

namespace JeopardyGame.Contracts
{
    public class Clue
    {
        [JsonPropertyName("answer")]
        public string Answer { get; set; }

        [JsonPropertyName("question")]
        public string Question { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }

        [JsonPropertyName("category")]
        public Category Category { get; set; }
    }
}
