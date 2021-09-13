using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GreetingsFromSpace.Api
{
    public class ApiHelper
    {
        const string apiKey = "uBqB40OtZrKwIcTumxXGcdsmS3zbrcPDlLqYFUCh";
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();

            // Base URL for the API
            ApiClient.BaseAddress = new Uri("https://api.nasa.gov/planetary/apod?api_key=" + apiKey);

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
