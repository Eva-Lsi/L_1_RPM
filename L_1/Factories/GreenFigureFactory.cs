using System.Windows.Media;
using AbstractFactory.Figures;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Конкретная фабрика, создающая зелёные фигуры.
    /// </summary>
    public class GreenFigureFactory : IFigureFactory
    {
        public Circle CreateCircle()
        {
            return new Circle { Color = Colors.Green };
        }

        public Square CreateSquare()
        {
            return new Square { Color = Colors.Green };
        }

        public Triangle CreateTriangle()
        {
            return new Triangle { Color = Colors.Green };
        }
    }
}