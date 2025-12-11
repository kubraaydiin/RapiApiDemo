using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiDemo.Models;

namespace RapiApiDemo.Controllers
{
    public class CurrencyApiController : Controller
    {
        public async Task<IActionResult> Currency()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/symbols"),
                Headers =
    {
        { "x-rapidapi-key", "7e2610f543msh4b5c8515e9e8191p122a55jsn5c750da7d0ed" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<CurrencyApiResponse>(body);

                return View(result);
            }
        }
    }
}
