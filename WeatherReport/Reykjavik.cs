using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class Reykjavik : Cities

    {
        public static int count;

        public static List<IWeather> ReykjavikList = new List<IWeather>();

        public static string CityName { get => WeatherInformation.Cities[0]; }

        public int DayNumber { get => count; }



    }
}
  
