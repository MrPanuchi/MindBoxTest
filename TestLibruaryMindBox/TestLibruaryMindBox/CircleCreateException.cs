using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibruaryMindBox
{
    public class CircleCreateException : Exception
    {
        public CircleCreateException(float radius, float exprad) : base($"Expected radius is {exprad}, specified is {radius}") { }
    }
}
