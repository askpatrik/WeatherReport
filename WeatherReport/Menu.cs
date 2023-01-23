using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WeatherReport
{
    internal class Menu
    {
    
            internal static ConsoleKeyInfo input;
            internal static int count = 1;
            internal static bool runMachine = true;
            public static void WeatherAppMenu()
            {
                do
                {
                    ConsoleKeyInfo input;
                    Console.Clear();
                Console.WriteLine($"Logged in as {Account.Username}");
                Console.WriteLine();
                Console.WriteLine("Welcome to the weather app! ");

                    Console.WriteLine();
                   

                    Console.WriteLine("1. Seven Day Forecasts");
                    Console.WriteLine("2. Forecast by Weather Condition");
                    Console.WriteLine("3. Terminate weather app");
                    Console.WriteLine();
                    Console.Write("What do you want to do?: ");

                    input = Console.ReadKey();


                    switch (input.KeyChar.ToString())
                    {
                        case "1":
                        Console.Clear();
                        Forecast.PrintWeeklyForecast();
                            break;
                        case "2":
                            Console.Clear();
                        Forecast.ChoseWeatherType();
                        break;
                        case "3":
                        Console.Clear();
                        Console.Write("Do you really want to terminate the weather app? (y/n): ");

                        input = Console.ReadKey();
                        if (input.KeyChar.ToString() == "n")
                            Menu.WeatherAppMenu();

                        if (input.KeyChar.ToString() == "y")
                        {
                            Console.Clear();
                            Console.WriteLine("Weather app shutting down in three seconds...");
                            Thread.Sleep(3000);
                            runMachine = false;
                            break;

                        }
                        break;

                    default:
                        Console.Clear();
                        Console.Write("You did not enter a valid number. Press any button to return: ");
                        Console.ReadKey();
                        WeatherAppMenu();

                        break;


                    }

                } while (runMachine);
            }
    }
}
