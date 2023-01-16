using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal interface IWeather
    {
       public int Temperature { get; }
       public string TypeOfWeather { get; }        
       

    }
}
