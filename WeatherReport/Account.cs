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
        public static Regex lettersAndNumbers = new Regex(@"[A-Za-z0-9]");

        public static void CreateAccount()
        {
            Console.WriteLine("To access the Weather app, you must first create an account.\nYou can only use letters, numbers and the input can max be 8 characters long.");
            Console.WriteLine();
                Console.Write("Enter username: ");
                Username = InputHandler.ValidInput();
                Console.Write("Enter password: ");
                Password = InputHandler.ValidInput();                        
            
        }
        public static void PrintAccountDetails()
        {
            Console.Write($"Account details. User name: {Account.Username}, Password: {Account.Password}.\nPress any key to continue to the Weather app!");
            Console.ReadLine();
        }
    
    }
}

