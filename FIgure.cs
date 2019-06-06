using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    public abstract class Figure
    {
        public abstract void CountFigureSquare();
        public abstract void DoesItFitsFigureBoundaries(double value);

        public double GetParameterFromKeyboard()
        {

            int i = 0;

            double parsedInput = 0;

            while (i < 3 && !double.TryParse(Console.ReadLine(), out parsedInput) && parsedInput <= 0)
            {
                Console.WriteLine("Invalid input, only integer or decimals higher than zero are accepted");
                i++;
            } 


            if (parsedInput == 0)
            {
                Random random = new Random();
                parsedInput = Math.Round(random.NextDouble(), 2);
                Console.WriteLine($"To much unsuccessful attempts, random value equals to {parsedInput} was set");
            }
            


            return parsedInput;

        }

    }
}
