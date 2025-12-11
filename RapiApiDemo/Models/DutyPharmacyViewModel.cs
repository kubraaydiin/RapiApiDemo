namespace RapiApiDemo.Models
{
    public class DutyPharmacyViewModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public DateTime recent_update { get; set; }
        public List<Location> locations { get; set; }
    }
    public class Location
    {
        public string city { get; set; }
        public string district { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}
