using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeatherReport
{
    internal class Account
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        public static void CreateAccount()
        {
            Regex lettersAndNumbers = new Regex(@"[A-Za-z0-9]");
            while (true)
            {
     
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();

                if (!lettersAndNumbers.IsMatch(username))
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid input. Must only contain letters and numbers");
                    continue;
                }
                else if (username.Trim().Length > 8)
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid input. Input can max be 8 characters long");
                    continue;
                }
                else
                    Username = username;
                

                
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (!lettersAndNumbers.IsMatch(password))
                    Console.WriteLine("Not a valid input. Must only contain letters and numbers");
                else if (password.Trim().Length > 8)
                    Console.WriteLine("Not a valid input. Input can max be 8 characters long");
                else
                {
                    Password = password;
                    break;
                }

           

            }
        }
        public static void PrintAccountDetails()
        {
            Console.WriteLine($"Account details. User name: {Account.Username}, Password: {Account.Password}");
            Console.ReadLine();
        }
    
    }
}

