using System.Windows.Media;
using AbstractFactory.Figures;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Конкретная фабрика, создающая красные фигуры. Все методы возвращают
    /// объекты с установленным красным цветом.
    /// </summary>
    public class RedFigureFactory : IFigureFactory
    {
        public Circle CreateCircle()
        {
            return new Circle { Color = Colors.Red };
        }

        public Square CreateSquare()
        {
            return new Square { Color = Colors.Red };
        }

        public Triangle CreateTriangle()
        {
            return new Triangle { Color = Colors.Red };
        }
    }
}