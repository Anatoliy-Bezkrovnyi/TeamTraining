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

            bool minInputIsNotCorrect = true;

            while (minInputIsNotCorrect)
            {
                if (int.TryParse(Console.ReadLine(), out minRange) && minRange >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Only integer higher or equal to '0' are accepted. Please, try again.");
                }
            }
        }

        public static void GetMaxRangeFromKeyboard()
        {

            Console.WriteLine("Please, enter maximal boundaries for the numbers list. Only integer higher or equal to '0' are accepted");

            bool maxInputIsNotCorrect = true;

            while (maxInputIsNotCorrect)
            {
                if (int.TryParse(Console.ReadLine(), out maxRange) && (maxRange - minRange > 10))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Only integer higher or equal to '0' are accepted. Difference between maximal and minimal boundaries should be more then 10. Please try again");
                }
            }
        }

        public static void ArrayMathOperations (int[] array)
        {
            int summOfTheElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 3 == 0) && (array[i] % 5 > 0))
                {
                    summOfTheElements += array[i];
                    Console.WriteLine(array[i]);
                    
                }
            }
            Console.WriteLine($"The sum of array elements which can be divided to 3 and can't be devided to 5 is {summOfTheElements}");
        }



    }
}

