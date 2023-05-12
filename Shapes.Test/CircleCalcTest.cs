using Shapes.BLL.Model;
using Shapes.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Test
{
    [TestClass]
    public class CircleCalcTest
    {
        CalcCircle calcManager = new CalcCircle();
        [TestMethod]
        public void CalcAreaCircle_Area1559_True()
        {
            //Arrange
            Circle circle = new Circle(10);
            //Act
            double result = calcManager.AreaCalc(circle);
            //Assert
            Assert.AreEqual(314, result);
        }
    }
}
