using System.Windows.Media;
using AbstractFactory.Figures;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Конкретная фабрика, создающая синие фигуры.
    /// </summary>
    public class BlueFigureFactory : IFigureFactory
    {
        public Circle CreateCircle()
        {
            return new Circle { Color = Colors.Blue };
        }

        public Square CreateSquare()
        {
            return new Square { Color = Colors.Blue };
        }

        public Triangle CreateTriangle()
        {
            return new Triangle { Color = Colors.Blue };
        }
    }
}