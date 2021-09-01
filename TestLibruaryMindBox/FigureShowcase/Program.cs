using System;
using TestLibruaryMindBox;

namespace FigureShowcase
{
    // Вычисление пощади без знания типа фигуры
    class Program
    {
        static void Main(string[] args)
        {
            IFigure[] figures = new IFigure[]
            {
                new Circle(4),
                new Triangle(2,4,3),
                new Circle(2)
            };
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetArea());
            }
        }
    }
}
