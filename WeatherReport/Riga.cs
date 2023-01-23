using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class RigaForecast : Cities

    {
        internal RigaForecast(IWeather weatherType) : base(weatherType)
        {
            this.Weathertype = weatherType;
            DayNumber = DateTime.Today.AddDays(count);
            RigaList.Add(this);
            count++;

        }

        public override IWeather Weathertype { get; set; }


        public static int count = 0;

        public override DateTime DayNumber { get; set; } 

        public override string CityName { get => WeatherAndCityInformation.Cities[1]; }


        public static List<Cities> RigaList = new List<Cities>();


    }
}