using System;
using Newtonsoft.Json;

namespace GetCryptoPrice
{
    public class WatchCoin
    {
        [JsonProperty("ask")]
        public string Ask { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }

        [JsonProperty("low")]
        public string Low { get; set; }

        [JsonProperty("high")]
        public string High { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("volumeQuote")]
        public string VolumeQuote { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

    }
}
