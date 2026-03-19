using System.Windows;
using System.Windows.Media;

namespace AbstractFactory.Figures
{
    /// <summary>
    /// Абстрактный продукт. Содержит цвет и метод для создания WPF‑элемента.
    /// </summary>
    public abstract class Figure
    {
        public Color Color { get; set; }
        public abstract UIElement CreateUIElement(double size = 50);
    }
}