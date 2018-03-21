using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Square.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void PerimHalf_35and45and55_675returned()
        {
            //arrange
            double x = 3.5;
            double y = 4.5;
            double z = 5.5;
            double expected = 6.75;


            //act
            double actual = Square.Triangle.PerimHalf(x,y,z);
            //assert
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void SquareTriangle_35and45and55_785returned()
        {
            //arrange
            double x = 3.5;
            double y = 4.5;
            double z = 5.5;
            double expected = 7.855;


            //act
            double actual = Square.Triangle.SquareTriangle(x, y, z);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightTriangle_3and4and5_TrueReturned()
        {
            //arrange
            double x = 3;
            double y = 4;
            double z = 5;
            bool expected = true;


            //act
            bool actual = Square.Triangle.IsRightTriangle(x, y, z);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareCircle_2_1256returned()
        {
            //arrange
            double x = 2;

            double expected = 12.566;


            //act
            double actual = Square.Circle.SquareCircle(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
