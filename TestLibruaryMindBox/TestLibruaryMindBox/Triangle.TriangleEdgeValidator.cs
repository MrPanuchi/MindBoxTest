namespace TestLibruaryMindBox
{
    public partial class Triangle
    {
        private class TriangleEdgeValidator
        {
            private const int EdgesCount = 3;
            private const float EdgeMinLength = 0;
            public void ValidateInputData(float[] edges)
            {
                CheckEdgesCount(edges);
                CheckEdgesLength(edges);
                CheckTriangleExisting(edges);
            }
            private void CheckEdgesCount(float[] edges)
            {
                if (edges.Length != EdgesCount)
                {
                    throw new TriangleCreateException(TriangleCreateException.ExceptionType.EdgeCountException, edges.Length);
                }
            }
            private void CheckEdgesLength(float[] edges)
            {
                for (int i = 0; i < edges.Length; i++)
                {
                    if (edges[i] <= EdgeMinLength)
                    {
                        throw new TriangleCreateException(TriangleCreateException.ExceptionType.EdgeLengthException, i, edges[i]);
                    }
                }
            }
            private void CheckTriangleExisting(float[] edges)
            {
                if (TriangleNotExist(edges))
                {
                    throw new TriangleCreateException(TriangleCreateException.ExceptionType.TriangleNotExistException, edges);
                }
            }
            private bool TriangleNotExist(float[] edges)
            {
                return edges[0] + edges[1] < edges[2] ||
                       edges[0] + edges[2] < edges[1] ||
                       edges[1] + edges[2] < edges[0];
            }
        }
    }
}
