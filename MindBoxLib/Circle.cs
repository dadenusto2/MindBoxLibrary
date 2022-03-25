using System;

namespace MindBoxLib
{
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
}
