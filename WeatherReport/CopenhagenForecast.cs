using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class CopenhagenForecast : Cities
    {
        public CopenhagenForecast(IWeather weatherType) : base(weatherType)
        {
        }

        public override string CityName => throw new NotImplementedException();

        public override DateTime DayNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IWeather Weathertype { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
