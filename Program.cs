using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();

            Console.WriteLine("Please enter circle radius (only integer and decimals are accepted), to count its square:");
            circle.GetParameterFromKeyboard();
            circle.CountFigureSquare();
            Console.WriteLine("Please enter square side (only integer and decimals are accepted), to count its square:");
            square.GetParameterFromKeyboard();
            square.CountFigureSquare();
        }
    }
}
