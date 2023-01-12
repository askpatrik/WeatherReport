﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class RainyDay : IWeather
    {

        public int Temperature { get => RandomNumberHandler.GenerateRandomTemperature(this); }
        public string TypeOfWeather { get => "Rainy"; }

        public override string ToString()
        {
            return $"Weather: {TypeOfWeather}, Temperature: {Temperature}";
        }
    }
}
