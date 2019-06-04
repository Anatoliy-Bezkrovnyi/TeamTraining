using System;

namespace FIgureSquare
{
    public class Square : Figure
    {
        
                             
            public Square ()
            {
                GetParameterFromKeyboard();
            }

                   

            public override void CountFigureSquare()
            {
                double squareSquare = Math.Pow(input, 2);
                Console.WriteLine($"Square square is equals to { squareSquare.ToString()}");
            }
    }
}


