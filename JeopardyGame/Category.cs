using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace JeopardyGame
{
    public class Category
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
