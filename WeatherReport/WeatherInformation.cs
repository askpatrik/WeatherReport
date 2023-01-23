using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class WeatherAndCityInformation
    {

     

        internal static Dictionary<string,string> WeatherTypes = new Dictionary<string,string>()
        {
            {"SunnyDay", "Sunny"},
            {"RainyDay", "Rainy"},
            {"CloudyDay", "Cloudy"},
            {"SnowyDay", "Snowy"}
        };
        internal static List<string> Cities = new List<string>()
        {
            {"Reykjavik"},
            {"Riga"},
            {"LasPalmas"},        
        };
    }
}
