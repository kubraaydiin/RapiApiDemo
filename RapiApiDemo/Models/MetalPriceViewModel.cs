namespace RapiApiDemo.Models
{
    public class MetalPriceViewModel
    {
        public bool success { get; set; }
        public string baseCurrency { get; set; }
        public string unit { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates
    {
        public decimal XAU { get; set; }
        public decimal XAG { get; set; }
        public decimal PA { get; set; }
        public decimal PL { get; set; }
        public decimal GBT { get; set; }
        public decimal EUR { get; set; }
    }
}