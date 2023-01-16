using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class WeatherInformation
    {

        public static List<Cities> MegaList = new List<Cities>();

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
            {"LasPalmas"},
            {"Riga"},        
        };
    }
}
