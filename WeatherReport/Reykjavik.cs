using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class ReykjavikForecast : Cities

    {
        public IWeather Weathertype { get; set; }

        public ReykjavikForecast(IWeather weatherType)
        {
            this.Weathertype = weatherType;
            DayNumber = count++;
            ReykjavikList.Add(this);

            WeatherInformation.MegaList.Add(this);

        }

        public static int count = 1;
        public string CityName { get => WeatherInformation.Cities[0]; }
        public int DayNumber { get; set; }

        public static List<Cities> ReykjavikList = new List<Cities>();



    }
}
  
