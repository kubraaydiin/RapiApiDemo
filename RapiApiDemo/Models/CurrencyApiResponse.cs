namespace RapiApiDemo.Models
{
    public class CurrencyApiResponse
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Symbols { get; set; }
    }
}
