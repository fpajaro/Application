using System;
using Newtonsoft.Json;

namespace Application.Models
{
    public class Event
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
