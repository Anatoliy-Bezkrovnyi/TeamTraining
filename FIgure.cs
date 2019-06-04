using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    public abstract class Figure
    {
        public double input { get; set; }

        public abstract void CountFigureSquare();

        public void GetParameterFromKeyboard()
        {
            bool isParsed = double.TryParse(Console.ReadLine(), out double parsedInput);
            int i = 1;

            double temp = 0.0d;

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

            if (temp != 0.0)
            {
                input = temp;
            }
            else
            {
                Random random = new Random();
                input = random.NextDouble();
                Console.WriteLine($"To much unsuccessful attempts, random value equals to {input.ToString()} was set");
            }


        }

    }
}
