using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    public class Circle : Figure
    {

        public double Radius { get; private set; }
        public Circle()
        {
            Radius = GetParameterFromKeyboard();
        }

        public const double pi = 3.14;

        public override void CountFigureSquare()
        {
            double circleSquare = pi * Math.Pow(Radius, 2);
            Console.WriteLine($"Circle square is equals to {circleSquare.ToString()}");
        }
        public override void DoesItFitsFigureBoundaries(double squareSide)
        {
            if (Radius * 2 <= squareSide)
            {
                Console.WriteLine("Your circle can be put into previously provided square.");
            }
            else
            {
                Console.WriteLine("Your circle is larger than previously provided square");
            }

            new NotImplementedException();
        }
    }
}
