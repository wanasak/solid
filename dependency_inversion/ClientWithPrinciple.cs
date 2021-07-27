using System;

namespace dependency_inversion
{
    public interface ISquareLogic
    {
        int CalculateArea(int side);
    }
    public class SquareLogicPrinciple : ISquareLogic
    {
        public int CalculateArea(int side)
        {
            return side * side;
        }
    }
    public class ClientWithPrinciple
    {
        ISquareLogic squareLogic;
        public ClientWithPrinciple()
        {
            squareLogic = new SquareLogicPrinciple();
        }

        public void Invoke()
        {
            Console.WriteLine(squareLogic.CalculateArea(2));
        }
    }
}
