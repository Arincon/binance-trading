using Arincon.Binance.Trading.Model;
using Binance.Api;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Arincon.Binance.Trading.Bot
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var api = new BinanceApi();

            if (await api.PingAsync())
                Console.WriteLine("SUCCESSFUL!");

            using (var user = new BinanceApiUser(Constants.BinanceAPIKey, Constants.BinanceAPISecret))
            {
                var userInfo = await api.GetAccountInfoAsync(user);
                Console.WriteLine(JsonConvert.SerializeObject(userInfo));
            }
            Console.WriteLine("...press any key to continue.");
            Console.ReadKey(true);
        }
    }
}
