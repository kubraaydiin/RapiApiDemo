namespace RapiApiDemo.Models
{
    public class CurrentWeatherViewModel
    {
        public string summery { get; set; }
        public Coord coord { get; set; }
        public Wind wind { get; set; }
        public Snow snow { get; set; }

    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double degrees { get; set; }
    }
    public class Snow
    {
        public double amount { get; set; }
        public string unit { get; set; }
    }
}
