using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract double Aria();
        public virtual double GetPerimeter() { return 0; }
        public abstract ShapeTypeEnum ShapeType
        {
            get;
        }
    }
}
