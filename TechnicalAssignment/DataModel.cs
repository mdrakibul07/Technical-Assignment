using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAssignment
{
    public class City
    {
        public string city { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string country { get; set; }
        public string iso2 { get; set; }
        public string admin_name { get; set; }
        public string capital { get; set; }
        public string population { get; set; }
        public string population_proper { get; set; }
    }
    public class CurrentWeather
    {
        public double temperature { get; set; }
        public double windspeed { get; set; }
        public double winddirection { get; set; }
        public int weathercode { get; set; }
        public string time { get; set; }
    }

    public class Response
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public CurrentWeather current_weather { get; set; }
    }
}
