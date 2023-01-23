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
        internal static ConsoleKeyInfo input;
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
            int count = 1;
            Console.Clear();

            Console.WriteLine("List of available cities.");
            Console.WriteLine();
            foreach (var item in WeatherAndCityInformation.Cities)
            {
                Console.WriteLine($"{count}: {item}");
                count++;
            }
            Console.WriteLine();
            Console.Write("Please enter which city you want to view a seven-day weather forecast for: ");
            input = Console.ReadKey();

            Console.Clear();
            switch (input.KeyChar.ToString())
            {
                case "1":
                    foreach (ReykjavikForecast item in ReykjavikForecast.ReykjavikList)
                        Console.WriteLine($"{item.CityName}, {item.DayNumber.ToString("dd MMMM")}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}°C");
                    Console.ReadLine();
                    break;

                case "2":
                    foreach (RigaForecast item in RigaForecast.RigaList)
                        Console.WriteLine($"{item.CityName}, {item.DayNumber.ToString("dd MMMM")}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}°C");
                    Console.ReadLine();
                    break;
                case "3":
                    foreach (LasPalmasForecast item in LasPalmasForecast.LasPalmasList)
                        Console.WriteLine($"{item.CityName}, {item.DayNumber.ToString("dd MMMM")}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}°C");
                    Console.ReadLine();
                    break;

                default:
                    Console.Clear();
                    Console.Write("You did not enter a valid number. Press any button to return: ");
                    Console.ReadKey();
                    PrintWeeklyForecast();
                    break;
            }

        }
        
        public static void ChoseWeatherType()
        {
            Console.Clear();
            int count = 1;

            Console.WriteLine("Available weather types.");
            Console.WriteLine();

            foreach (var item in WeatherAndCityInformation.WeatherTypes)
            {
                Console.WriteLine($"{count}: {item.Value}");
                count++;
            }

            Console.WriteLine();
            Console.Write("Chose weather condition: ");
            input = Console.ReadKey();

            switch (input.KeyChar.ToString())
            {
                case "1":
                    PrintForecastByWeather("Sunny");
                    break;
                case "2":
                    PrintForecastByWeather("Rainy");
                    break;
                case "3":
                    PrintForecastByWeather("Cloudy");
                    break;
                case "4":
                    PrintForecastByWeather("Snowy");
                    break;

                default:
                    Console.Clear();
                    Console.Write("You did not enter a valid number. Press any button to return: ");
                    Console.ReadKey();
                    ChoseWeatherType();
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
                    Console.WriteLine($"{item.CityName}, {item.DayNumber.ToString("dd MMMM")}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}°C");
            
            foreach (RigaForecast item in RigaForecast.RigaList)
                if (item.Weathertype.TypeOfWeather == weather)
                    Console.WriteLine($"{item.CityName}, {item.DayNumber.ToString("dd MMMM")}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}°C");
         
            foreach (LasPalmasForecast item in LasPalmasForecast.LasPalmasList)
                if (item.Weathertype.TypeOfWeather == weather)
                    Console.WriteLine($"{item.CityName}, {item.DayNumber.ToString("dd MMMM")}, Weather: {item.Weathertype.TypeOfWeather}, Temp:  {item.Weathertype.Temperature}°C");

            Console.ReadLine();

        }
    }
}

    