using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Figure.Models;
using Rectangle = Figure.Models.Rectangle;

namespace Figure.View
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        string figureInfo = "";
        public MainWindowView()
        {
            InitializeComponent();
        }

        private int CentimeterToPixel(double Centimeter)
        {
            return Convert.ToInt32(Centimeter * 37.8);
        }

        private void DrawCircle_Click(object sender, RoutedEventArgs e)
        {
            if (FigurePanel.Children.Count == 1)
                FigurePanel.Children.Remove(FigurePanel.Children[0]);
            Circle circle = new Circle(5);
            FigurePanel.Children.Add(circle.Draw());
            figureInfo = circle.Info();
        }

        private void DrawRectangle_Click(object sender, RoutedEventArgs e)
        {
            if (FigurePanel.Children.Count == 1)
                FigurePanel.Children.Remove(FigurePanel.Children[0]);
            Figure.Models.Rectangle rectangle = new Figure.Models.Rectangle(3, 5);
            FigurePanel.Children.Add(rectangle.Draw());
            figureInfo = rectangle.Info();
        }

        private void DrawSquare_Click(object sender, RoutedEventArgs e)
        {
            if (FigurePanel.Children.Count == 1)
                FigurePanel.Children.Remove(FigurePanel.Children[0]);
            Square square = new Square(5);

            FigurePanel.Children.Add(square.Draw());
            figureInfo = square.Info();
        }

        private void DrawTriangle_Click(object sender, RoutedEventArgs e)
        {
            if (FigurePanel.Children.Count == 1)
                FigurePanel.Children.Remove(FigurePanel.Children[0]);
            Triangle triangle = new Triangle(6, 8, 10);
            
            FigurePanel.Children.Add(triangle.Draw());
            figureInfo = triangle.Info();

        }

        private void ShowInfoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(figureInfo);
        }
    }
}
