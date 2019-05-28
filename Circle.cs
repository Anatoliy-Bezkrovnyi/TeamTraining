using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    public class Circle : Figure
    {
        public static double radius;
        public const double pi = 3.14;
        

public override double CountFigureSquare(double radius)
        {
            return pi* radius * radius;
        }
    }
}
