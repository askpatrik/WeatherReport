using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class RigaForecast : Cities

    {
        public IWeather Weathertype { get; set; }

        public RigaForecast(IWeather weatherType)
        {
            this.Weathertype = weatherType;
            DayNumber = count++;
            RigaList.Add(this);

            WeatherInformation.MegaList.Add(this);

        }

        public static int count = 1;
        public string CityName { get => WeatherInformation.Cities[2]; }
        public int DayNumber { get; set; }

        public static List<Cities> RigaList = new List<Cities>();



    }
}