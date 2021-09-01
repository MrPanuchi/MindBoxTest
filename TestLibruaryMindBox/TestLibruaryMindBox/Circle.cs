using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibruaryMindBox
{
    public class Circle : IFigure
    {
        private const float MinRadius = float.Epsilon;
        private float radius;

        public Circle(float radius)
        {
            CheckRadius(radius);
            this.radius = radius;
        }

        private void CheckRadius(float radius)
        {
            if (radius < MinRadius)
            {
                throw new CircleCreateException(radius, MinRadius);
            }
        }

        public float GetRaduis { get => radius; }

        public float GetArea()
        {
            return MathF.PI * MathF.Pow(radius, 2);
        }
    }
}
