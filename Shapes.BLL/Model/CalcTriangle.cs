using Shapes.BLL.Abstract;
using Shapes.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.BLL.Model
{
    public class CalcTriangle : Calc
    {
        public double Area { get; set; }
        public CalcTriangle()
        {

        }
        //Вычисление площади по формуле Герона
        public double CalcArea(Triangle triangle)
        {
            double area = 0;
            if (triangle.IsRectangular)
            {
                return area = 0.5*triangle.FirstCathet*triangle.SecondCathet;
            }
            double p = (triangle.Hypotenuse + triangle.FirstCathet + triangle.SecondCathet)/2; //Полупериметр
            return area = Math.Sqrt(p*(p - triangle.Hypotenuse)*(p - triangle.FirstCathet) *(p - triangle.SecondCathet)); //Площадь
        }
    }
}
