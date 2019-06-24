using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    public static class Helper
    {
        public static String GetStringFromKeyboard()
        {
            Console.WriteLine("Enter string to check whether it is palindrom or not");
            String input = Console.ReadLine();
            input = input.Trim().ToLower();

            return input;
        }
    }
}
