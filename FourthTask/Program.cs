using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOperations.CheckIfStringIsPalindrome(StringOperations.ConvertStringToAlphaNumericArray(Helper.GetStringFromKeyboard()));
            Console.ReadLine();
        }
    }
}
