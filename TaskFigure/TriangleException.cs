using System;

namespace TaskFigure
{
    public class TriangleException : Exception
    {
        public TriangleException(string message) : base(message) { }

        public TriangleException(string message, Exception inner)
            : base(message, inner) { }
    }
}
