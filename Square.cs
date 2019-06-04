using System;

namespace FIgureSquare
{
    public class Square : Figure
    {
        
                             
            public Square ()
            {
                GetParameterFromKeyboard();
            }

            private double side = Parameter;        

            public override void CountFigureSquare()
            {
                double squareSquare = Math.Pow(side, 2);
                Console.WriteLine($"Square square is equals to { squareSquare.ToString()}");
            }
    }
}


