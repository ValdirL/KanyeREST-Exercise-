using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeREST
{
    public class QuoteGenerator
    {
        private HttpClient _client;

        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }
        public string KanyeQuote()
        {
            //API URL
            var kanyeURL = "https://api.kanye.rest ";
            //Stores the JSON response in a variable
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
            //This parses through the response we recieve to get the value associated
            //with the name "quote"
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonQuote()
        {

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;

        }
    }
}
