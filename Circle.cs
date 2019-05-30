using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    public class Circle : Figure
    {
        public double radius;
        public const double pi = 3.14;
        

public override void CountFigureSquare()
        {
            double circleSquare = pi* Math.Sqrt(radius);
            Console.WriteLine($"Circle square is equals to {circleSquare.ToString()}");
        }
    }
}
