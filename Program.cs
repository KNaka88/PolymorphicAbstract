using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda")};
            
            foreach(Shape s in myShapes)
            {
                s.Draw();
            }
            
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            // calls the Draw() method of the parent
            ((Circle)o).Draw();

            Console.ReadLine();
        }
    }
}
