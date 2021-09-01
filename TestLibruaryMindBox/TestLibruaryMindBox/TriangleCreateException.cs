using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibruaryMindBox
{
    public class TriangleCreateException : Exception
    {
        public enum ExceptionType
        {
            EdgeCountException,
            EdgeLengthException,
            TriangleNotExistException
        }

        public TriangleCreateException(ExceptionType type, int edgesCount) : base($"Expected 3 edge, actual is {edgesCount}")
        {
            Type = type;
        }

        public TriangleCreateException(ExceptionType type, int index, float sideLength) : base($"Side which index is {index} has wrong length: {sideLength}")
        {
            Type = type;
        }

        public TriangleCreateException(ExceptionType type, float[] edges) : base($"Triangle with edges {edges[0]}, {edges[1]}, {edges[2]} - can't exist")
        {
            Type = type;
        }

        public readonly ExceptionType Type;
    }
}
