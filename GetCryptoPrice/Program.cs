using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Threading;
using System.Text;
using System.Linq;

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

            var currentCrypto = JsonConvert.DeserializeObject<Dictionary<string,string>>(jsonData);

            Console.WriteLine(currentCrypto["last"]);

        }


        public static void GetTraddingBalance()
        {
            string api = ""; // write here your API key
            string secretKey = ""; //write here your secret key
            string convertedTo64 = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{api}:{secretKey}"));

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.Authorization, $"Basic {convertedTo64}");
            string jsonData = client.DownloadString("https://api.hitbtc.com/api/2/trading/balance");

            var tBalance = JsonConvert.DeserializeObject<List<Coin>>(jsonData);

            var displayBalance = tBalance.Where(b => b.Available != "0" ).ToList();
            displayBalance.ForEach(b => Console.WriteLine(b.Available));
        }



        static void StartTimer(object state)
        {
            PrintCurrentPrice();
        }

        public static void Main(string[] args)
        {

            GetTraddingBalance();
            Console.WriteLine("-------------------------------");

            Timer timer = new Timer(StartTimer, null, 0, 2000);
            Console.ReadLine();


        }


    }
}
