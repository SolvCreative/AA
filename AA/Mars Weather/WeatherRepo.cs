using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using AA.Models;

namespace AA.Mars_Weather
{
    public class WeatherRepo : IWeatherRepo
    {
        public static string connectionString;


        public IEnumerable<WeatherViewModel> GetWeather()
        {
            throw new Exception();
        }
    }
}
