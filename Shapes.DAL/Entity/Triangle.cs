using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.DAL.Abstract;

namespace Shapes.DAL.Entity
{
    public class Triangle : Shape
    {
        public readonly bool IsRectangular; //Прямоугольность
        public double FirstCathet; //Первый катет
        public double SecondCathet; //Второй катет
        public double Hypotenuse; //Гипотенуза
        public Triangle(double firstCathet, double secondCathet, double hypotenuse) : base()
        {
            FirstCathet = firstCathet;
            SecondCathet = secondCathet;
            Hypotenuse = hypotenuse;
            if (Math.Pow(hypotenuse, 2) == Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2))
            {
                IsRectangular = true;
            }
        }
    }
}
