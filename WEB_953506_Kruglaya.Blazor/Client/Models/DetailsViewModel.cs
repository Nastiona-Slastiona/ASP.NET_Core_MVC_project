using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WEB_953506_Kruglaya.Blazor.Client.Models
{
    public class DetailsViewModel
    {
        [JsonProperty("name")]
        public string MoovieName { get; set; } = "";
        [JsonProperty("description")]
        public string Description { get; set; } = "";
        [JsonProperty("time")]
        public int Time { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }

    }
}
