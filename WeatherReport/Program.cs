using System;

namespace WeatherReport
{
    internal class Program
    {

          
        static void Main(string[] args)
        {
            

            int count = 1;
            Forecast.GenerateForecast();

            foreach (var day in Forecast.listOfDays)
            {
                Console.WriteLine($"Day {count}: {day.TypeOfWeather}, Temperature: {day.Temperature}");
                count++;
            }
        }
    }
}