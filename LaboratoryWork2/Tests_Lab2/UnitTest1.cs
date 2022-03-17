using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1;
using Task_2;


namespace Tests_Lab2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkIsTriangleExists1()
        {
            double a = 1.37, b = 2.78, c = 3.77;

            triangle triangle1 = new triangle();

            string expected = "Треугольник существует!";
            string actual = triangle1.triangleIsExists(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void checkIsTriangleExists2()
        {
            double a = 1.37, b = 2.78, c = 6.77;

            triangle triangle1 = new triangle();

            string expected = "Треугольник не существует!";
            string actual = triangle1.triangleIsExists(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void checkWhereIsPoint1()
        {
            double x = 1.12, y = 1.23;

            Point point1 = new Task_2.Point();

            string expected = "Да";
            string actual = point1.whereIsPoint(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void checkWhereIsPoint2()
        {
            double x = 123.23, y = -54.123;

            Point point1 = new Task_2.Point();

            string expected = "Нет";
            string actual = point1.whereIsPoint(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void checkWhereIsPoint3()
        {
            double x = 7.5, y = 5;

            Point point1 = new Task_2.Point();

            string expected = "На границе";
            string actual = point1.whereIsPoint(x, y);
            Assert.AreEqual(expected, actual);
        }

    }


}
