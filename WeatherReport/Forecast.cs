﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class Forecast
    {
        public static void GenerateWeeklyForecasts()
        {
            for (int i = 0; i < 7; i++)
            {
                new ReykjavikForecast(GetWeatherType());
                new RigaForecast(GetWeatherType());
                new LasPalmasForecast(GetWeatherType());
            }
        }
        public static IWeather GetWeatherType()
        {
            var randomNumber = RandomNumberHandler.GenerateRandomWeatherType();

            switch (randomNumber)
            {
                case 1: return new SunnyDay(); break;
                case 2: return new RainyDay(); break;
                case 3: return new SnowyDay(); break;
                case 4: return new CloudyDay(); break;

                default: return null; break;
            }
        }

        public static void PrintWeeklyForecast()
        {
            Console.WriteLine("1: Reyjkjavik, 2: Riga, 3: LasPalmas");
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    foreach (ReykjavikForecast item in ReykjavikForecast.ReykjavikList)
                        Console.WriteLine($"{item.CityName}, Day {item.DayNumber}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}");
                    break;

                case 2:
                    foreach (RigaForecast item in RigaForecast.RigaList)
                        Console.WriteLine($"{item.CityName}, Day {item.DayNumber}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}");
                    break;
                case 3:
                    foreach (LasPalmasForecast item in LasPalmasForecast.LasPalmasList)
                        Console.WriteLine($"{item.CityName}, Day {item.DayNumber}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}");
                    break;

                default:
                    break;
            }

        }
        public static void PrintForecastByWeather(string weather)
        {
            Console.Clear();

            Console.WriteLine($"City and Day when it is {weather} weather");
            Console.WriteLine();

            foreach (ReykjavikForecast item in ReykjavikForecast.ReykjavikList)
                if (item.Weathertype.TypeOfWeather == weather)
                    Console.WriteLine($"{item.CityName}, Day {item.DayNumber}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}");
            foreach (RigaForecast item in RigaForecast.RigaList)
                if (item.Weathertype.TypeOfWeather == weather)
                    Console.WriteLine($"{item.CityName}, Day {item.DayNumber}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}");
            foreach (LasPalmasForecast item in LasPalmasForecast.LasPalmasList)
                if (item.Weathertype.TypeOfWeather == weather)
                    Console.WriteLine($"{item.CityName}, Day {item.DayNumber}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}");

        }
    }
}

    