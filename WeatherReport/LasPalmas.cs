using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class LasPalmasForecast : Cities

    {
        public IWeather Weathertype { get; set; }

        public LasPalmasForecast(IWeather weatherType)
        {
            this.Weathertype = weatherType;
            DayNumber = count++;
            LasPalmasList.Add(this);

            WeatherInformation.MegaList.Add(this);

        }

        public static int count = 1;
        public string CityName { get => WeatherInformation.Cities[1]; }
        public int DayNumber { get; set; }

        public static List<Cities> LasPalmasList = new List<Cities>();



    }
}
