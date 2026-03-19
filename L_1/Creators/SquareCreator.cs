using FactoryMethod.Figures;
using System.Windows.Media;

namespace FactoryMethod.Creators
{

    public abstract class SquareCreator
    {
        public abstract Square CreateSquare();
    }

    public class RedSquareCreator : SquareCreator
    {
        public override Square CreateSquare()
        {
            return new Square { Color = Colors.Red };
        }
    }

    public class BlueSquareCreator : SquareCreator
    {
        public override Square CreateSquare()
        {
            return new Square { Color = Colors.Blue };
        }
    }

    public class GreenSquareCreator : SquareCreator
    {
        public override Square CreateSquare()
        {
            return new Square { Color = Colors.Green };
        }
    }
}