using System;

namespace MindBox
{
    public class FigureException : ArgumentException
    {
        public FigureException(string message)
            : base(message)
        { }
    }
}
