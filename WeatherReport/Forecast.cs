using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class Forecast     
    {
        public static int Days = 7;
        public static List<IWeather> listOfDays = new List<IWeather>();
        //7 day forecast randomizses betwwen sunnyday, rainyday

        public static void GenerateForecast()
        {
            for (int i = 0; i < Days; i++)           
                AddWeatherDay();           
        }
        public static void AddWeatherDay()
        {
            var choice = RandomNumberHandler.GenerateRandomNumber();

            switch (choice)
            {
                case 1: listOfDays.Add(new SunnyDay()); break;
                case 2: listOfDays.Add(new RainyDay()); break;
                default:
                    break;
            }
        }

    }
}
