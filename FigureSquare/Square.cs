using System;

namespace FIgureSquare
{
    public class Square : Figure
    {
        public double Side { get; private set; }


        public Square()
        {
            Side = GetParameterFromKeyboard();
        }



        public override void CountFigureSquare()
        {
            double squareSquare = Math.Round(Math.Pow(Side, 2), 2);
            Console.WriteLine($"Square area is equals to { squareSquare}");
        }
        public override void DoesItFitsFigureBoundaries(double circleRadius)
        {
            if (Side <= Math.Sqrt(2 * Math.Pow(circleRadius, 2)))
            {
                Console.WriteLine("Your square can be put into previously provided circle.");
            }
            else
            {
                Console.WriteLine("Your square is larger than previously provided circle.");
            }
        }
    }
}


