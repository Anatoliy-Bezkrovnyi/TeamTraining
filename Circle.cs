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
            radius = Parameter;
            double circleSquare = pi* Math.Pow(radius, 2);
            Console.WriteLine($"Circle square is equals to {circleSquare.ToString()}");
        }
    }
}
