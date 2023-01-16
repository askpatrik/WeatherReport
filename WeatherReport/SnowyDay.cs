using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class SnowyDay: IWeather
    {

        public SnowyDay(string city)
        {
            City = city;
            counter++;
        }

        public int counter;
        public int DayNumber { get => counter; }

        public string City { get; set; }
        public int Temperature { get => RandomNumberHandler.GenerateRandomTemperature(this); }
        public string TypeOfWeather { get => WeatherInformation.WeatherTypes[GetType().Name]; }



        public override string ToString()
        {
            return $"Weather: {TypeOfWeather}, Temperature: {Temperature}";
        }
    }
}

 