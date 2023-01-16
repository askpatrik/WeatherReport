using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class RandomNumberHandler
    {
        internal static Random random = new Random();
        internal static int randomNumber = random.Next(1, 5);

        internal static int GenerateRandomWeatherType()
        {
            randomNumber = random.Next(1, 5);
            return randomNumber;
        }
        internal static int GenerateRandomTemperature(IWeather weatherType)
        {
            switch (weatherType)
            {
                case SunnyDay: randomNumber = random.Next(15, 28); break;
                case RainyDay: randomNumber = random.Next(10, 18); break;
                case CloudyDay: randomNumber = random.Next(15, 22); break;
                case SnowyDay: randomNumber = random.Next(-15, -1); break;
                default: break;
            }      
            return randomNumber;
        }
    }
}
