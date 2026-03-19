using System.Windows;
using System.Windows.Controls;
using FactoryMethod.Creators;

namespace FactoryMethod
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     
        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                // Remove all previously created shapes
                FiguresPanel.Children.Clear();

                // Determine which set of creators to use based on the selected colour
                CircleCreator circleCreator;
                SquareCreator squareCreator;
                TriangleCreator triangleCreator;

                switch (selectedItem.Content.ToString())
                {
                    case "Красный":
                        circleCreator = new RedCircleCreator();
                        squareCreator = new RedSquareCreator();
                        triangleCreator = new RedTriangleCreator();
                        break;
                    case "Синий":
                        circleCreator = new BlueCircleCreator();
                        squareCreator = new BlueSquareCreator();
                        triangleCreator = new BlueTriangleCreator();
                        break;
                    case "Зелёный":
                        circleCreator = new GreenCircleCreator();
                        squareCreator = new GreenSquareCreator();
                        triangleCreator = new GreenTriangleCreator();
                        break;
                    default:
                        return;
                }

                // Create the figures and add their UI elements to the panel
                var circle = circleCreator.CreateCircle();
                FiguresPanel.Children.Add(circle.CreateUIElement());

                var square = squareCreator.CreateSquare();
                FiguresPanel.Children.Add(square.CreateUIElement());

                var triangle = triangleCreator.CreateTriangle();
                FiguresPanel.Children.Add(triangle.CreateUIElement());
            }
        }
    }
}