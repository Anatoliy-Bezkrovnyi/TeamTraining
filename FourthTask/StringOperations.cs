using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FourthTask
{
    public static class StringOperations
    {
        public static char[] ConvertStringToAlphaNumericArray(String input)
        {
            input = Regex.Replace(input, "[^а-яa-z0-9_]", "" );
            char[] trimmedString = input.ToCharArray();

            /*for (int i = 0; i < trimmedString.Length; i++)
            {
                Console.WriteLine(trimmedString[i]);
            }*/

            return trimmedString;
            
        }
        public static void CheckIfStringIsPalindrome(char[] trimmedArray)
        {
            int lastArrayMemberIndex = trimmedArray.Length - 1;

            /*for (int i = 0; i < trimmedArray.Length; i++)
            {

                if (i == trimmedArray.Length - 1)
                {
                    Console.WriteLine("Entered phrase is palindrom.");
                    break;
                }

                if (trimmedArray[i] == trimmedArray[lastArrayMemberIndex])
                {
                    lastArrayMemberIndex--;
                }
                else
                {
                    Console.WriteLine("Entered phrase is not palindrom.");
                    break;
                }
            }*/

            for (int i = 0; i < lastArrayMemberIndex; i++)
            {
                if (trimmedArray[i] != trimmedArray[lastArrayMemberIndex - i])
                {
                    Console.WriteLine("Entered phrase is not palindrom.");
                    break;
                }                         
                    
                
                if (i == lastArrayMemberIndex - i)                              
                {
                    Console.WriteLine("Entered phrase is palindrom.");
                }
            }

        }
    }
}
