using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiDemo.Models;
using System.Text.Json.Serialization;

namespace RapiApiDemo.Controllers
{
    public class MoviesController : Controller
    {
        public async Task<IActionResult> ImdTop100List()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                        {
                            { "x-rapidapi-key", "7e2610f543msh4b5c8515e9e8191p122a55jsn5c750da7d0ed" },
                            { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
                        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ImdbMovieViewModel>>(body);
                return View(values.ToList());
            }
        }
    }
}
