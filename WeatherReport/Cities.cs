using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal abstract class Cities
    {

        public Cities(IWeather weatherType) { }
              
        public abstract string CityName { get; }
        public abstract DateTime DayNumber { get; set; }
     
        public abstract IWeather Weathertype { get; set; }

      
    }
}
