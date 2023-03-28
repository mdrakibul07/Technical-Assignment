using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace TechnicalAssignment
{
    public class DataProcessing
    {
        public Response LoadApiData(decimal latitude, decimal longitude)
        {
            Response response = new Response();
            var url = "https://api.open-meteo.com/v1/forecast?latitude=" + latitude + "&longitude=" + longitude + "&current_weather=true";
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString(url);
                response = JsonConvert.DeserializeObject<Response>(result);               
            }
            return response;
        }

        public List<City> LoadJson()
        {
            List<City> citys = new List<City>();
            using (StreamReader r = new StreamReader("india.json"))
            {
                string json = r.ReadToEnd();
                citys = JsonConvert.DeserializeObject<List<City>>(json);
            }
            return citys;
        }
    }
}
