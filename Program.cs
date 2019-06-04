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
            
            

            Console.WriteLine("Please enter circle radius (only integer or decimals lager than zero are accepted), to count its square:");
            Circle circle = new Circle();
            circle.CountFigureSquare();
            Console.WriteLine("Please enter square side (only integer or decimals lager than zero are accepted), to count its square:");
            Square square = new Square();
            square.CountFigureSquare();
            Console.ReadLine();
        }
    }
}
