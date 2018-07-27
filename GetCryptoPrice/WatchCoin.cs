using System;
using GetCryptoPrice.Properties;
using Newtonsoft.Json;


namespace GetCryptoPrice
{
    public class WatchCoin
    {
        public static double LastChange { get; set; }

        [JsonProperty("ask")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double Ask { get; set; }

        [JsonProperty("bid")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double Bid { get; set; }

        [JsonProperty("last")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double Last { get; set; }

        [JsonProperty("open")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double Open { get; set; }

        [JsonProperty("low")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double Low { get; set; }

        [JsonProperty("high")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double High { get; set; }

        [JsonProperty("volume")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double Volume { get; set; }

        [JsonProperty("volumeQuote")]
        [JsonConverter(typeof(JsonStringToNumberConverter))]
        public double VolumeQuote { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }


    }
}
