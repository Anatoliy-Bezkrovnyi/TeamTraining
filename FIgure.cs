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

        public void GetParameterFromKeyboard()
        {
            while (!Double.TryParse(Console.ReadLine(), out double parsedInput))
            {
                Console.WriteLine("Incorrect input, double is expected");
                Console.ReadLine();
            }
            Double parameter = Double.Parse(Console.ReadLine());
        }
        
    }
}
