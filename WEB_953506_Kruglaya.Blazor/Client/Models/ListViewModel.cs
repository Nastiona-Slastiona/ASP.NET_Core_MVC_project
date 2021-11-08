using Newtonsoft.Json;

namespace WEB_953506_Kruglaya.Blazor.Client.Models
{
    public class ListViewModel
    {
        //[JsonProperty("id")]
        public int MoovieId { get;set; }
        //[JsonProperty("name")]
        public string MoovieName { get; set; } = "moovie";

    }

}
