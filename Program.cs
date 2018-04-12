using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();

            Circle cir = new Circle("Cindy");
            cir.Draw();
            Console.ReadLine();
        }
    }
}
