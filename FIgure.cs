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
            bool isParsed = double.TryParse(Console.ReadLine(), out double parsedInput);
            int i = 1;

            double temp = 0;

            while (i < 3)
            {
                if (!isParsed || parsedInput <= 0)

                {
                    Console.WriteLine("Invalid input, only integer or decimals higher than zero are accepted");
                    i++;
                }
                else
                {
                    temp = parsedInput;
                }
                Console.ReadLine();

            }

            if (temp == 0)
            {
                Random random = new Random();
                temp = random.NextDouble();
                Console.WriteLine($"To much unsuccessful attempts, random value equals to {temp} was set");
            }


            return temp;
        }

    }
}
