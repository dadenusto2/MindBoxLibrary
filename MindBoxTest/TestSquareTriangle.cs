using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxLib;
using System;

namespace MindBoxTest
{
    [TestClass]
    public class TestSquareTriangle // Тестирование площади треугольника  
    {
        [TestMethod]
        public void SquareTriangle_Test_Triangle()// тест площади правильного
        {
            // длинны
            double a = 3;
            double b = 4;
            double c = 5;
            double p = (a + b + c) / 2;// полупериметр
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));//площадь через формулу для равнобедренного

            double actual = Triangle.square(a, b, c);//площадь

            Assert.AreEqual(expected, actual);//проверка
        }

        [TestMethod]
        public void SquareTriangle_Test_IsoscelesTriangle()// тест площади равнобедренного
        {
            double a = 10;
            double b = 10;
            double c = 8;
            double p = (a + b + c) / 2;// полупериметр
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            double actual = Triangle.square(a, b, c);//площадь

            Assert.AreEqual(expected, actual);//проверка
        }

        [TestMethod]
        public void SquareTriangle_Test_DoubleTriangle()// тест площади
        {
            double a = 1.75;
            double b = 1.5;
            double c = 2;
            double p = (a + b + c) / 2;// полупериметр
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            double actual = Triangle.square(a, b, c);//площадь

            Assert.AreEqual(expected, actual);//проверка
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareTriangle_Test_TriangleNotExists1()// тест несущесвующего 1
        {
            double a = 3;
            double b = 3;
            double c = 6;

            Triangle.square(a, b, c);
        }

        //тесты с вызовом исключений
        [TestMethod]
        [ExpectedException(typeof(FigureException))]//ожидаемая ошибка
        public void SquareTriangle_Test_TriangleNotExists2()// тест несущесвующего 1
        {
            double a = 1.5;
            double b = 1.3;
            double c = 7;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareTriangle_Test_NegativeSide()// тест с отрицательной стороной
        {
            double a = 3;
            double b = -4;
            double c = 5;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareTriangle_Test_NegativeSides()// тест со всеми отрицательными сторонами
        {
            double a = -3;
            double b = -4;
            double c = -5;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareTriangle_Test_ZeroSide()// тест с нулевой стороной
        {
            double a = 3;
            double b = 4;
            double c = 0;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareTriangle_Test_ZeroSides()// тест со всеми нулевыми сторонами
        {
            double a = 0;
            double b = 0;
            double c = 0;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareTriangle_Test_ZeroAndNeegativeSides()// тест с отрицательной и нулевой сторонами
        {
            double a = 0;
            double b = -4;
            double c = 3;

            Triangle.square(a, b, c);
        }
    }
}
