using System;

namespace FIgureSquare
{
    public class Square : Figure
    {
        
            public double side;
            

            public override void CountFigureSquare()
            {
                side = Parameter;
                double squareSquare = Math.Pow(side, 2);
                Console.WriteLine($"Square square is equals to { squareSquare.ToString()}");
            }
    }
}


