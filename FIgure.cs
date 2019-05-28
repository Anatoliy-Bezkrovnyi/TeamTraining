using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    public abstract class Figure
    {
        public double parameter;
        public abstract double CountFigureSquare(double parameter);
        public void GetParameterFromKeyboard()
        {
            while (!Double.TryParse(Console.ReadLine(), out double parsedInput))
            {
                Console.WriteLine("Неверный ввод");
                Console.ReadLine();
            }
            parameter = Double.Parse(Console.ReadLine());
        }
        
    }
}
