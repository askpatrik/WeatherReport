using System;
using System.Dynamic;

namespace WeatherReport
{
    internal class Program
    {
      

        static void Main(string[] args)
        {           
            Account.CreateAccount();           
            Account.PrintAccountDetails();  
            Forecast.GenerateWeeklyForecasts();
            Menu.WeatherAppMenu();
            
            
         
          





        }
    }
}