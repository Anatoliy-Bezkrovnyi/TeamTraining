using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdTask
{
    public class Helper
    {
        public static int minRange;
        public static int maxRange;
        public static void GetMinRangeFromKeyboard()
        {

            Console.WriteLine("Please, enter minimal boundaries for the numbers list. Only integer higher or equal to '0' are accepted");

            int parsedInputMin;
            bool minInputIsNotCorrect = true;

            while (minInputIsNotCorrect)
            {
                if (int.TryParse(Console.ReadLine(), out parsedInputMin) && parsedInputMin >= 0)
                {
                    minRange = parsedInputMin;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Only integer higher or equal to '0' are accepted");
                }
            }



        }

        public static void GetMaxRangeFromKeyboard()
        {

            Console.WriteLine("Please, enter maximal boundaries for the numbers list. Only integer higher or equal to '0' are accepted");

            int parsedInputMax;
            bool maxInputIsNotCorrect = true;

            while (maxInputIsNotCorrect)
            {
                if (int.TryParse(Console.ReadLine(), out parsedInputMax) && (parsedInputMax - minRange > 10))
                {
                    maxRange = parsedInputMax;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Only integer higher or equal to '0' are accepted. Difference between maximal and minimal boundaries should be more then 10");
                }
            }



        }



    }
}

