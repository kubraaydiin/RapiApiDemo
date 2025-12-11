using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiDemo.Models;

namespace RapiApiDemo.Controllers
{
    public class CurrencyController : Controller
    {
        public async Task<IActionResult> CurrencyConvert()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=EUR&amount=750"),
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
                var value = JsonConvert.DeserializeObject<CurrencyViewModel>(body);
                ViewBag.v = value.result;
                return View();
            }
        }
    }
}
