using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox;
using System;

namespace MindBoxTest
{
    [TestClass]
    public class TestCircle // Тестирование окружности 
    {
        [TestMethod]
        public void SquareCircle_Test_IntegerRadious()// тест натурального радиуса
        {
            double r = 10;//радиус
            double expected = Math.PI * Math.Pow(r, 2);//ожидаемая площадь

            double actual = Circle.square(r);
    
            Assert.AreEqual(expected, actual);//проверка
        }

        [TestMethod]
        public void SquareCircle_Test_DoubleRadious()// тест положительного вещесвенного радиуса
        {
            double r = 2.5;
            double expected = Math.PI * Math.Pow(r, 2);


            double actual = Circle.square(r);

            Assert.AreEqual(expected, actual);
        }

        //тесты с вызовом исключений
        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]//ожидаемое исключение
        public void SquareCircle_Test_ZeroRadious()// тест нулевого радиуса
        {
            double r = 0;

            Circle.square(r);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareCircle_Test_NegativeInteger()// тест отрицательного целого радиуса
        {

            double r = -10;

            Circle.square(r);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareCircle_Test_NegativeDouble()// тест отрицательного вещесвенного радиуса
        {

            double r = -2.4;//радиус=

            Circle.square(r);
        }
    }

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
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_TriangleNotExists1()// тест несущесвующего 1
        {
            double a = 3;
            double b = 3;
            double c = 6;

            Triangle.square(a, b, c);
        }

        //тесты с вызовом исключений
        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]//ожидаемая ошибка
        public void SquareTriangle_Test_TriangleNotExists2()// тест несущесвующего 1
        {
            double a = 1.5;
            double b = 1.3;
            double c = 7;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_NegativeSide()// тест с отрицательной стороной
        {
            double a = 3;
            double b = -4;
            double c = 5;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_NegativeSides()// тест со всеми отрицательными сторонами
        {
            double a = -3;
            double b = -4;
            double c = -5;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_ZeroSide()// тест с нулевой стороной
        {
            double a = 3;
            double b = 4;
            double c = 0;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_ZeroSides()// тест со всеми нулевыми сторонами
        {
            double a = 0;
            double b = 0;
            double c = 0;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_ZeroAndNeegativeSides()// тест с отрицательной и нулевой сторонами
        {
            double a = 0;
            double b = -4;
            double c = 3;

            Triangle.square(a, b, c);
        }
    }

    [TestClass]
    public class TestRightTriangle // Тестирование прямоугольного треугольника  
    {
        [TestMethod]
        public void RightTriangle_Test_RightTriangle1()// тест прямоугольного 1
        {
            double a = 5;
            double b = 12;
            double c = 13;
            bool expected = true;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void RightTriangle_Test_RightTriangle2()// тест прямоугольного 2
        {
            double a = 10;
            double b = Math.Sqrt(84);
            double c = 4;
            bool expected = true;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightTriangle_Test_NotRightTriangle1()// тест не прямоугольного 1
        {
            // проверка обычного
            double a = 13;
            double b = 14;
            double c = 15;
            bool expected = false;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightTriangle_Test_NotRightTriangle2()// тест не прямоугольного 2
        {
            // проверка обычного
            double a = 11;
            double b = Math.Sqrt(84);
            double c = 4;
            bool expected = false;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        //тесты с вызовом исключений
        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_ZeroSide()// тест c нулевой стороной
        {
            // проверка с нулевой стороной
            double a = 0;
            double b = 12;
            double c = 13;
            
            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_ZeroSides()// тест c нулевыми сторонами
        {
            // проверка с нулевой стороной
            double a = 0;
            double b = 0;
            double c = 0;

            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_NegativeSide()// тест c отрицательной стороной
        {
            // проверка с нулевой стороной
            double a = -5;
            double b = 12;
            double c = 13;

            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_NegativeSides()// тест c отрицательными сторонами
        {
            // проверка с нулевой стороной
            double a = -5;
            double b = -12;
            double c = -13;

            Triangle.checkRightTriangle(a, b, c);
        }
    }
}
