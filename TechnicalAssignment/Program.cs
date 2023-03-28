using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TechnicalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter City: ");
            string inputCity = Console.ReadLine();
            Console.WriteLine("Entered City is : " + inputCity);
            try
            {
                DataProcessing dataProcessing = new DataProcessing();
                List<City> cities = dataProcessing.LoadJson();
                City slectedCity = cities.Where(t => t.city.ToLower() == inputCity.ToLower()).FirstOrDefault();
                if (slectedCity != null)
                {
                    Response response = dataProcessing.LoadApiData(Convert.ToDecimal(slectedCity.lat), Convert.ToDecimal(slectedCity.lng));
                    if (response != null)
                    {
                        Console.WriteLine(Environment.NewLine + "Current Weather (Latitude: " + slectedCity.lat+ " , Longitude: " + slectedCity.lng+")");
                        Console.WriteLine(Environment.NewLine + "Temperature : " + response.current_weather.temperature);
                        Console.WriteLine(Environment.NewLine + "Wind Speed : " + response.current_weather.windspeed);
                        Console.WriteLine(Environment.NewLine + "Wind Direction : " + response.current_weather.winddirection);
                        Console.WriteLine(Environment.NewLine + "Weather Code : " + response.current_weather.weathercode);
                        Console.WriteLine(Environment.NewLine + "Time : " + response.current_weather.time);
                    }
                    else
                    {
                        Console.WriteLine("No Record found.");
                    }
                }
                else
                {
                   
                    Console.WriteLine("City not found in Database. ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }




    }

}
