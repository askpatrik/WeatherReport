using System;
using System.Dynamic;

namespace WeatherReport
{
    internal class Program
    {


        static void Main(string[] args)
        {
           Forecast.GenerateWeeklyForecast(Reykjavik.ReykjavikList, Reykjavik.CityName, new Reykjavik());
           Forecast.PrintForecast(Reykjavik.ReykjavikList);

            //Dag! 
           Forecast.PrintOnlyByWeather(WeatherInformation.WeatherTypes["SunnyDay"]);



        }
    }
}