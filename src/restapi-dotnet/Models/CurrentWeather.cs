using System;

namespace restapi_dotnet.Models
{
    public class CurrentWeather
    {        
        public DateTime Date { get; set; }

        public string Summary { get; set; }

        public string Location { get; set; }

        public decimal Temperature { get; set; }

        public decimal Humidity { get; set; }

        public decimal Visibility { get; set; }

        public int UVIndex { get; set; }
    }
}
