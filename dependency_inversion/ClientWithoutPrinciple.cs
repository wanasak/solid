using System;

namespace dependency_inversion
{
    public class ClientWithoutPrinciple
    {
        SquareLogic squareLogic;

        public ClientWithoutPrinciple()
        {
            squareLogic = new SquareLogic();
        }

        public void Invoke()
        {
            Console.WriteLine(squareLogic.CalculateArea(2));
        }
    }
    public class SquareLogic
    {
        public int CalculateArea(int side)
        {
            return side * side;
        }
    }
}
