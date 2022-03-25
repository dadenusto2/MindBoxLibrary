using System;

namespace MindBoxLibrary
{
    // Площадь окружности
    public static class Circle // cтатичный класс, т.к. не создаем объектов этого класса
    {
        public static double square(double a)//площадь
        {
            if (a > 0)
            {
                return Math.PI * a * a;
            }
            return null;
        }
    }
    // Площадь и проверка прямоугольного треугольника
    public static class Triangle
    {
        public static bool isExists(double a, double b, double c)//проверка существования треугольника
        {
            return (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a);
        }
        public static double square(double a, double b, double c)//площадь
        {
            if (isExists(a, b, c))
            {
                double p = (a + b + c) / 2;// полупериметр
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));//формула Герона
            }
            return null;
        }
        public static bool checkRightTriangle(double a, double b, double c)//проверка прямоугольного
        {
            if (isExists(a, b, c))
            {
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
            //если треугольник не сущесвует
            else
            {
                return false;
            }
        }
    }
}
