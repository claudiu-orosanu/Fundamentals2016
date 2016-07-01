using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public static int count = 0;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            count++;
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public override ShapeTypeEnum ShapeType
        {
            get
            {
                return ShapeTypeEnum.Rectangle;
            }
        }

        public void setWidth(double width)
        {
            if(width > length)
                Console.WriteLine("Dreptunghiul nu e valid");
            else
                this.width = width;
        }
        public double getWidth()
        {
            return width;
        }

        public override string ToString()
        {
            return "Length: " + length + " Width: " + width;
        }

        public override double Aria()
        {
            return width * length;
        }

        public virtual double GetPerimeter()
        {
            return 2 * length + 2 * width;
        }

    }
}
