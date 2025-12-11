using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiDemo.Models;

namespace RapiApiDemo.Controllers
{
    public class CurrentWeatherController : Controller
    {
        public async Task<IActionResult> Weather()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weather-api167.p.rapidapi.com/api/weather/current?place=London%2CGB&units=standard&lang=en&mode=json"),
                Headers =
    {
        { "x-rapidapi-key", "7e2610f543msh4b5c8515e9e8191p122a55jsn5c750da7d0ed" },
        { "x-rapidapi-host", "weather-api167.p.rapidapi.com" },
        { "Accept", "application/json" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<CurrentWeatherViewModel>(body);
                return View(result);
            }
            }
        }
    }

