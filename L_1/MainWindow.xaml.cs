using System.Windows;
using System.Windows.Controls;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IFigureFactory currentFactory;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                // Choose the appropriate factory based on the selected colour
                switch (selectedItem.Content.ToString())
                {
                    case "Красный":
                        currentFactory = new RedFigureFactory();
                        break;
                    case "Синий":
                        currentFactory = new BlueFigureFactory();
                        break;
                    case "Зелёный":
                        currentFactory = new GreenFigureFactory();
                        break;
                    default:
                        return;
                }

                FiguresPanel.Children.Clear();

                var circle = currentFactory.CreateCircle();
                FiguresPanel.Children.Add(circle.CreateUIElement());

                var square = currentFactory.CreateSquare();
                FiguresPanel.Children.Add(square.CreateUIElement());

                var triangle = currentFactory.CreateTriangle();
                FiguresPanel.Children.Add(triangle.CreateUIElement());
            }
        }
    }
}