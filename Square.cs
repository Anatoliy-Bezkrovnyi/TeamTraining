using System;

namespace FIgureSquare
{
    public class Square : Figure
    {
        
            public double side;
            

            public override void CountFigureSquare()
            {
                double squareSquare = Math.Sqrt(side);
                Console.WriteLine($"Square square is equals to { squareSquare.ToString()}");
            }
    }
}


