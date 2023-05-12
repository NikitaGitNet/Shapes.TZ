using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.DAL.Abstract;

namespace Shapes.DAL.Entity
{
    public class Circle : Shape
    {
        public double Radius;
        public Circle(double radius) : base()
        {
            Radius = radius;
        }
    }
}
