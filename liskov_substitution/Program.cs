using System;

namespace liskov_substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            AppleNormal apple = new OrangeNormal();
            Console.WriteLine(apple.GetColor()); // Still get red color

            // Liskov Substitution
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
