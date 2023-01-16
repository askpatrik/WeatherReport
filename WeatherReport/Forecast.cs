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
        public static int count = 1;

        public static List<IWeather> MegaList = new List<IWeather>();


        public static void GenerateWeeklyForecast(List<IWeather> cityList, string city, Reykjavik theCity)
        {
            for (int i = 0; i < Days; i++)
            {
                var randomNumber = RandomNumberHandler.GenerateRandomWeatherType();

                switch (randomNumber)
                {
                    case 1: cityList.Add(new SunnyDay(city, theCity.DayNumber)); break;
                    case 2: cityList.Add(new RainyDay(city)); break;
                    case 3: cityList.Add(new CloudyDay(city)); break;
                    case 4: cityList.Add(new SnowyDay(city)); break;
                    default: break;

                }

            }
        }
        /*
        public static void GenerateWeeklyForecast(List<IWeather> cityList, string city)
        {
            for (int i = 0; i < Days; i++)
            {
                var randomNumber = RandomNumberHandler.GenerateRandomWeatherType();

                switch (randomNumber)
                {
                    case 1: cityList.Add(new SunnyDay(city)); break;
                    case 2: cityList.Add(new RainyDay(city)); break;
                    case 3: cityList.Add(new CloudyDay(city)); break;
                    case 4: cityList.Add(new SnowyDay(city)); break;
                    default: break;

                }

            }
        }
        */
        public static void PrintForecast(List<IWeather> cityList)
        {
            
            //Show the 7 days
            foreach (var weather in cityList)
            {
                Console.WriteLine($"[{weather.City}] Day {weather.DayNumber}: {weather.TypeOfWeather}, Temp: {weather.Temperature}°C");
                count++;
            }
        }




        public static void PrintOnlyByWeather(string weatherType)
        {
          

            foreach (var weather in Reykjavik.ReykjavikList)
            {
                if (weather.TypeOfWeather == weatherType)
                    Console.WriteLine($"[{weather.City}] Day {count}: {weather.TypeOfWeather}, Temp: {weather.Temperature}°C");
            }

        }

    }
}