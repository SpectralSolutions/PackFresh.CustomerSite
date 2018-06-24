using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace PackFresh.CustomerSite.Models
{
    

    public partial class ProductRange
    {
        [JsonProperty("Range")]
        public string Range { get; set; }

        [JsonProperty("Sub Range")]
        public string SubRange { get; set; }

        [JsonProperty("Product")]
        public string ProductProduct { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("MIC")]
        public string Mic { get; set; }

        [JsonProperty("Size")]
        public string Size { get; set; }

        [JsonProperty("MOQ")]
        public string Moq { get; set; }

        [JsonProperty("Price")]
        public string Price { get; set; }

        [JsonProperty("StandardColours")]
        public string StandardColours { get; set; }
    }

}
