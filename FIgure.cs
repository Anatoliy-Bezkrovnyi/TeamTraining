using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIgureSquare
{
    public abstract class Figure
    {   
        public double Parameter { get; set; }
        
        public abstract void CountFigureSquare();

        public void GetParameterFromKeyboard()
        {
            double parsedInput = 0;
            while (!(double.TryParse(Console.ReadLine(), out parsedInput) && parsedInput > 0)) 
            {

                Console.WriteLine("Invalid input, only integer or decimals higher than zero are accepted");
            }
            Parameter = parsedInput;
        }
        
    }
}
