using System;

namespace MindBoxLib
{
    public class FigureException : ArgumentException//класс исключения
    {
        public FigureException(string message)
            : base(message)
        { }
    }
}
