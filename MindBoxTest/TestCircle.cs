using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxLib;
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
        [ExpectedException(typeof(FigureException))]//ожидаемое исключение
        public void SquareCircle_Test_ZeroRadious()// тест нулевого радиуса
        {
            double r = 0;

            Circle.square(r);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareCircle_Test_NegativeInteger()// тест отрицательного целого радиуса
        {

            double r = -10;

            Circle.square(r);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void SquareCircle_Test_NegativeDouble()// тест отрицательного вещесвенного радиуса
        {

            double r = -2.4;//радиус=

            Circle.square(r);
        }
    }
}
