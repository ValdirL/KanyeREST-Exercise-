using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.KanyeQuote()}");

                Console.WriteLine($"Ron Swanson: {quote.RonQuote()}");
            }
        }
    }
}
