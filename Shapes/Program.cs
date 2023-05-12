using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();

        }
    }
}
