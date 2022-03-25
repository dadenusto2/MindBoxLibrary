using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox;
using System;

namespace MindBoxTest
{
    [TestClass]
    public class TestCircle // ������������ ���������� 
    {
        [TestMethod]
        public void SquareCircle_Test_IntegerRadious()// ���� ������������ �������
        {
            double r = 10;//������
            double expected = Math.PI * Math.Pow(r, 2);//��������� �������

            double actual = Circle.square(r);
    
            Assert.AreEqual(expected, actual);//��������
        }

        [TestMethod]
        public void SquareCircle_Test_DoubleRadious()// ���� �������������� ������������ �������
        {
            double r = 2.5;
            double expected = Math.PI * Math.Pow(r, 2);


            double actual = Circle.square(r);

            Assert.AreEqual(expected, actual);
        }

        //����� � ������� ����������
        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]//��������� ����������
        public void SquareCircle_Test_ZeroRadious()// ���� �������� �������
        {
            double r = 0;

            Circle.square(r);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareCircle_Test_NegativeInteger()// ���� �������������� ������ �������
        {

            double r = -10;

            Circle.square(r);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareCircle_Test_NegativeDouble()// ���� �������������� ������������ �������
        {

            double r = -2.4;//������=

            Circle.square(r);
        }
    }

    [TestClass]
    public class TestSquareTriangle // ������������ ������� ������������  
    {
        [TestMethod]
        public void SquareTriangle_Test_Triangle()// ���� ������� �����������
        {
            // ������
            double a = 3;
            double b = 4;
            double c = 5;
            double p = (a + b + c) / 2;// ������������
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));//������� ����� ������� ��� ���������������

            double actual = Triangle.square(a, b, c);//�������

            Assert.AreEqual(expected, actual);//��������
        }

        [TestMethod]
        public void SquareTriangle_Test_IsoscelesTriangle()// ���� ������� ���������������
        {
            double a = 10;
            double b = 10;
            double c = 8;
            double p = (a + b + c) / 2;// ������������
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            double actual = Triangle.square(a, b, c);//�������

            Assert.AreEqual(expected, actual);//��������
        }

        [TestMethod]
        public void SquareTriangle_Test_DoubleTriangle()// ���� �������
        {
            double a = 1.75;
            double b = 1.5;
            double c = 2;
            double p = (a + b + c) / 2;// ������������
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            double actual = Triangle.square(a, b, c);//�������

            Assert.AreEqual(expected, actual);//��������
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_TriangleNotExists1()// ���� �������������� 1
        {
            double a = 3;
            double b = 3;
            double c = 6;

            Triangle.square(a, b, c);
        }

        //����� � ������� ����������
        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]//��������� ������
        public void SquareTriangle_Test_TriangleNotExists2()// ���� �������������� 1
        {
            double a = 1.5;
            double b = 1.3;
            double c = 7;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_NegativeSide()// ���� � ������������� ��������
        {
            double a = 3;
            double b = -4;
            double c = 5;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_NegativeSides()// ���� �� ����� �������������� ���������
        {
            double a = -3;
            double b = -4;
            double c = -5;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_ZeroSide()// ���� � ������� ��������
        {
            double a = 3;
            double b = 4;
            double c = 0;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_ZeroSides()// ���� �� ����� �������� ���������
        {
            double a = 0;
            double b = 0;
            double c = 0;

            Triangle.square(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void SquareTriangle_Test_ZeroAndNeegativeSides()// ���� � ������������� � ������� ���������
        {
            double a = 0;
            double b = -4;
            double c = 3;

            Triangle.square(a, b, c);
        }
    }

    [TestClass]
    public class TestRightTriangle // ������������ �������������� ������������  
    {
        [TestMethod]
        public void RightTriangle_Test_RightTriangle1()// ���� �������������� 1
        {
            double a = 5;
            double b = 12;
            double c = 13;
            bool expected = true;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void RightTriangle_Test_RightTriangle2()// ���� �������������� 2
        {
            double a = 10;
            double b = Math.Sqrt(84);
            double c = 4;
            bool expected = true;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightTriangle_Test_NotRightTriangle1()// ���� �� �������������� 1
        {
            // �������� ��������
            double a = 13;
            double b = 14;
            double c = 15;
            bool expected = false;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightTriangle_Test_NotRightTriangle2()// ���� �� �������������� 2
        {
            // �������� ��������
            double a = 11;
            double b = Math.Sqrt(84);
            double c = 4;
            bool expected = false;

            bool actual = Triangle.checkRightTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        //����� � ������� ����������
        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_ZeroSide()// ���� c ������� ��������
        {
            // �������� � ������� ��������
            double a = 0;
            double b = 12;
            double c = 13;
            
            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_ZeroSides()// ���� c �������� ���������
        {
            // �������� � ������� ��������
            double a = 0;
            double b = 0;
            double c = 0;

            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_NegativeSide()// ���� c ������������� ��������
        {
            // �������� � ������� ��������
            double a = -5;
            double b = 12;
            double c = 13;

            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(MindBox.FigureException))]
        public void RightTriangle_Test_NegativeSides()// ���� c �������������� ���������
        {
            // �������� � ������� ��������
            double a = -5;
            double b = -12;
            double c = -13;

            Triangle.checkRightTriangle(a, b, c);
        }
    }
}
