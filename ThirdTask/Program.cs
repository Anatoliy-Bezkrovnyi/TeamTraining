using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersList numbers = new NumbersList();

            Helper.GetMinRangeFromKeyboard();
            Helper.GetMaxRangeFromKeyboard();
            Console.WriteLine($"Array of integers from {Helper.minRange} to {Helper.maxRange} was created");
            Helper.ArrayMathOperations(numbers.CreateNumbersArray());
        }
    }
}
