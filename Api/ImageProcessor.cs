using GreetingsFromSpace.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GreetingsFromSpace.Api
{
    public class ImageProcessor
    {
        public static async Task<APOD> GetImage()
        {
            // Fetches the base URL of the API and converts it to a string
            string url = ApiHelper.ApiClient.BaseAddress.ToString();

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    APOD image = await response.Content.ReadAsAsync<APOD>();

                    return image;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
