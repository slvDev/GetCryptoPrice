using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Threading;

namespace GetCryptoPrice
{
    class MainClass
    {

        public static void PrintCurrentPrice()
        {
            //Create webclient for GET request
            var client = new WebClient();
            string jsonData = client.DownloadString("https://api.hitbtc.com/api/2/public/ticker/BTCUSD");

            //Serialize current info about coin
            var currentCrypto = new Dictionary<string, string>();
            var serializer = new JsonSerializer();
            using (var reader = new StringReader(jsonData))
            using (var jsonReader = new JsonTextReader(reader))
            {
                currentCrypto = serializer.Deserialize<Dictionary<string, string>>(jsonReader);
            }
            Console.WriteLine(currentCrypto["last"]);
        }

        static void StartTimer(object state)
        {
            PrintCurrentPrice();
        }

        public static void Main(string[] args)
        {

            Timer timer = new Timer(StartTimer, null, 500, 2000);

            Console.ReadLine();


        }


    }
}
