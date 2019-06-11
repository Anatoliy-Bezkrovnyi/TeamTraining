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

            int i = 3;

            double figureDimension = 0;

            while (i > 0)
            {
                if (double.TryParse(Console.ReadLine(), out double parsedInput) && parsedInput > 0)
                {
                    figureDimension = parsedInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, only integer or decimals higher than zero are accepted");
                    i--;
                }
            }

            if (i == 0)
            {
                Random random = new Random();
                figureDimension = Math.Round((random.Next(45) / 10) + 0.5, 2);
                Console.WriteLine($"To much unsuccessful attempts, random value equals to {figureDimension} was set");
            }



            return figureDimension;

        }

    }
}
