using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxLib;
using System;

namespace MindBoxTest
{
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
        [ExpectedException(typeof(FigureException))]
        public void RightTriangle_Test_ZeroSide()// ���� c ������� ��������
        {
            // �������� � ������� ��������
            double a = 0;
            double b = 12;
            double c = 13;
            
            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void RightTriangle_Test_ZeroSides()// ���� c �������� ���������
        {
            // �������� � ������� ��������
            double a = 0;
            double b = 0;
            double c = 0;

            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
        public void RightTriangle_Test_NegativeSide()// ���� c ������������� ��������
        {
            // �������� � ������� ��������
            double a = -5;
            double b = 12;
            double c = 13;

            Triangle.checkRightTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureException))]
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
