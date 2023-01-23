using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WeatherReport
{
    internal class InputHandler
    {
        public static Regex lettersAndNumbers = new Regex(@"[A-Za-z0-9]");

        static string ReadNull()
        {
            string input = Console.ReadLine();
            while (input.Trim(' ') == String.Empty)
            {

                Console.Write("You did not write anything. Please try again.");
                input = Console.ReadLine();
            }
            return input;
        }
        static int ReadInt()
        {
            //Returnerar INT om den går att parsa, annars får användaren ange ett nytt värde
            int heltal;
            while (int.TryParse(Console.ReadLine(), out heltal) == false)
            {
                Console.WriteLine("You did not enter a number. Please try again.");
            }
            return heltal;
        }
      public static string ValidInput()
        {
            string input = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                if (!lettersAndNumbers.IsMatch(input))
                {
                    Console.Write("Not a valid input. ONLY letters and numbers.\nTry again: ");
                    input = Console.ReadLine();
                    continue;
                }
                if (input.Length > 8)
                {
                    Console.Write("Not a valid input. Max 8 characters long \nTry again: ");
                    input = Console.ReadLine();
                    continue;
                }
                break;

            }
            return input;
           
        }
    }
}