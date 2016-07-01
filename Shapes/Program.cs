using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1= new Rectangle(10, 20);
            Console.WriteLine(rectangle1);
            Console.WriteLine(rectangle1.Aria());
            Console.WriteLine(rectangle1.GetPerimeter());
            Console.WriteLine(rectangle1.ShapeType);

            Shape shape = new Rectangle(20, 10);
            Rectangle rectangle = new Rectangle(20, 20);
            Console.WriteLine(rectangle.Aria());
            Console.WriteLine(shape.Aria());

            Console.ReadKey();
        }
    }
}
