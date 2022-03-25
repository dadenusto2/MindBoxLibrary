using System;

namespace MindBox
{
    // Площадь окружности
    public static class Circle // cтатичный класс, т.к. не создаем объектов этого класса
    {
        private static void isExists(double a)//проверка существования круга
        {
            if (a <= 0)
                throw new FigureException("Figure does not exist!");//ошибка если не прошел проверку
        }
        public static double square(double a)//площадь
        {
            isExists(a);
            return Math.PI * a * a;
        }
    }

    // Площадь и проверка прямоугольного треугольника
    public static class Triangle
    {
        private static void isExists(double a, double b, double c)//проверка существования треугольника
        {
            if (!(a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a))
                throw new FigureException("Figure does not exist!");//ошибка если не прошел проверку
        }
        public static double square(double a, double b, double c)//площадь
        {
            isExists(a, b, c);
            double p = (a + b + c) / 2;// полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));//формула Герона
        }
        public static bool checkRightTriangle(double a, double b, double c)//проверка прямоугольного
        {
            isExists(a, b, c);
            //ищем предполагаемую гипотенузу
            if (a > b && a > c)
            {
                return (a * a == b * b + c * c);//проверяем по тео. Пифагора
            }
            else if (b > a && b > c)
            {
                return (b * b == a * a + c * c);
            }
            else if (c > a && c > b)
            {
                return (c * c == a * a + b * b);
            }
            // если гипотенуза не найдена
            else
            {
                return false;
            }
        }
    }
}