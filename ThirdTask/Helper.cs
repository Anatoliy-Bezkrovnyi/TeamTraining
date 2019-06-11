using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdTask
{
    public class Helper
    {
        public static int minRange;
        public static int maxRange;
        public static void GetNumbersRangeFromKeyboard()
        {            

            Console.WriteLine("Please, enter minimal boundaries for the numbers list. Only integer higher or equal to '0' are accepted");

            int parsedInputMin;

            while (!(int.TryParse(Console.ReadLine(), out parsedInputMin) && parsedInputMin >= 0))
            {
                Console.WriteLine("Invalid input. Only integer higher or equal to '0' are accepted");
            }                          
                
            minRange = parsedInputMin;

            Console.WriteLine("Please, enter maximal boundaries for the numbers list. Only integer higher or equal to '0' are accepted");

            int parsedInputMax;

            while (!(int.TryParse(Console.ReadLine(), out parsedInputMax) && parsedInputMin >= 0))
            {
                Console.WriteLine("Invalid input. Only integer higher or equal to '0' are accepted");
            }

            maxRange = parsedInputMax;
        }
        
            
            
    }
}

