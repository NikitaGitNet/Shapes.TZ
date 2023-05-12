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
    public class TriangleCalcTest
    {
        private CalcTriangle calcManager = new CalcTriangle();
        [TestMethod]
        public void NonRectangularCalcAreaTriangle_Area1559_True()
        {
            //Arrange
            Triangle triangle = new Triangle(6,6,6);
            //Act
            double result = Math.Round(calcManager.CalcArea(triangle), 2);
            //Assert
            Assert.AreEqual(15.59, result);
        }
        [TestMethod]
        public void CalcAreaTriangle_Area1559_True()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            //Act
            double result = Math.Round(calcManager.CalcArea(triangle), 2);
            //Assert
            Assert.AreEqual(6, result);
        }
    }
}
