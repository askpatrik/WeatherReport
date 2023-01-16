using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class SunnyDay : IWeather
    {
        public SunnyDay(string city, int dayNumber)
        {
            City = city;
            DayNumber = dayNumber;
        }

        public int counter;
        public int DayNumber { get; }
        public string City { get; set; }

        
        public int Temperature { get => RandomNumberHandler.GenerateRandomTemperature(this);}                             
        public string TypeOfWeather { get => WeatherInformation.WeatherTypes[GetType().Name]; }

       
        public override string ToString()
        {
            return $"Weather: {TypeOfWeather}, Temperature: {Temperature}";
        }
    }
}
