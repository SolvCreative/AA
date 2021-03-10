using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using AA.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace AA.Mars_Weather
{
    public class WeatherRepo : IWeatherRepo
    {
        public static string connectionString;

        private HttpClient _client;
        public void Mars_Weather(HttpClient client)
        {
            _client = client;
        }

        IEnumerable<WeatherViewModel> IWeatherRepo.GetWeather()
        {
            string apiURL = "https://api.nasa.gov/insight_weather/?api_key=N2yotKWcogakcIbS22F3mgR0tSaEsYwb0PVmfKBz";
            var apiResponse = _client.GetStringAsync(apiURL).Result;
            var weatherData = JObject.Parse(apiResponse).GetValue("<SOL>").ToList();
            return (IEnumerable<WeatherViewModel>)weatherData.ToList();
        }

       
    }
}
