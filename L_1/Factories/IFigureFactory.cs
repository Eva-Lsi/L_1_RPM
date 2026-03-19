using AbstractFactory.Figures;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Интерфейс абстрактной фабрики. Определяет фабричные методы для создания
    /// каждой фигуры. Клиентский код должен зависеть только от этого интерфейса,
    /// а не от конкретных фабрик или продуктов.
    /// </summary>
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }
}