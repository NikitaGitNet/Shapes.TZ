using Shapes.BLL.Abstract;
using Shapes.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.BLL.Model
{
    public class CalcCircle : Calc
    {
        const double Pi = 3.14; //Число "Пи"
        public double Area { get;set; } //Площадь
        public CalcCircle()
        {

        }
        //Высчитывание площади
        public double AreaCalc(Circle circle)
        {
            double area = 0;
            return area = Pi * Math.Pow(circle.Radius, 2);
        }
    }
}
