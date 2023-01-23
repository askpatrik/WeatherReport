using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class CloudyDay : IWeather

    {
        public int Temperature { get => RandomNumberHandler.GenerateRandomTemperature(this); }
        public string TypeOfWeather { get => WeatherAndCityInformation.WeatherTypes[GetType().Name]; }

    }
}
