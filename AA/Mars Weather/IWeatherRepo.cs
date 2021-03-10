using AA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Mars_Weather
{
    public interface IWeatherRepo
    {
        public IEnumerable<WeatherViewModel> GetWeather();


    }
}
