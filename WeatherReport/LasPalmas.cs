using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class LasPalmasForecast : Cities

    {
        public LasPalmasForecast(IWeather weatherType) : base(weatherType)
        {
            this.Weathertype = weatherType;
            DayNumber = DateTime.Today.AddDays(count);
            LasPalmasList.Add(this);
            count++;

        }

        public override IWeather Weathertype { get; set; }

        public static int count = 0;

        public override DateTime DayNumber { get; set; }

        public override string CityName { get => WeatherAndCityInformation.Cities[2]; }


        public static List<Cities> LasPalmasList = new List<Cities>();

    }
}
