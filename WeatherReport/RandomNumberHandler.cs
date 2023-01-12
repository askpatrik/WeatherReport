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

        internal static int GenerateRandomNumber()
        {
            randomNumber = random.Next(1, 3);
            return randomNumber;
        }
        internal static int GenerateRandomTemperature(IWeather weatherType)
        {
            switch (weatherType)
            {
                case SunnyDay: randomNumber = random.Next(15, 28); break;
                case RainyDay: randomNumber = random.Next(10, 18); break;
                default:
                    break;
            }
            //if get Type = SunnyDay ... 
            
            return randomNumber;

        }
    }
}
