using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibruaryMindBox
{
    public partial class Triangle : IFigure
    {
        private float[] edges;
        public Triangle(params float[] edges)
        {
            (new TriangleEdgeValidator()).ValidateInputData(edges);
            this.edges = edges;
        }
        public IEnumerable<float> GetEdges
        {
            get
            {
                return edges;
            }
        }
        public float GetPerimetr()
        {
            return edges[0] + edges[1] + edges[2];
        }
        public float GetArea()
        {
            float halfOfperimetr = GetPerimetr() / 2;
            float halfMinusA = halfOfperimetr - edges[0];
            float halfMinusB = halfOfperimetr - edges[1];
            float halfMinusC = halfOfperimetr - edges[2];
            return (float)(Math.Sqrt(halfOfperimetr * halfMinusA * halfMinusB * halfMinusC));
        }
        public bool IsRightTriangle()
        {
            return PythagoreanTheoremCheck(edges[0], edges[1], edges[2]) ||
                   PythagoreanTheoremCheck(edges[0], edges[2], edges[1]) ||
                   PythagoreanTheoremCheck(edges[1], edges[2], edges[0]);
        }
        private bool PythagoreanTheoremCheck(float a, float b, float c)
        {
            const int digitsAfterPoint = 2;
            double aSquare = Math.Pow(edges[0], 2);
            double bSquare = Math.Pow(edges[1], 2);
            double cSquare = Math.Pow(edges[2], 2);
            double cathetSquareSum = aSquare + bSquare;
            return Math.Round(cathetSquareSum, digitsAfterPoint) == Math.Round(cSquare, digitsAfterPoint); // нужно обсудить точность округления
        }
    }
}
