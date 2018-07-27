using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GetCryptoPrice
{

    public class Ballance
    {
        public List<Coin> Coins { get; set; }
    }

    public class Coin
    { 
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("available")]
        public string Available { get; set; }

        [JsonProperty("reserved")]
        public string Reserved { get; set; }
    }


}
