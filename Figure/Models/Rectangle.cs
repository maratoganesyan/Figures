using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using Figure.Tools;
using System.Drawing;

namespace Figure.Models
{
    internal class Rectangle : FigureBase
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        protected override double P() => Height * 2 + Width * 2;

        protected override double S() => Height * Width;

        public override FrameworkElement Draw()
        {
            System.Windows.Shapes.Rectangle rec = new System.Windows.Shapes.Rectangle();
            rec.Width = MyConverter.CentimeterToPixel(this.Width);
            rec.Height = MyConverter.CentimeterToPixel(this.Height);
            rec.Stroke = Brushes.Black;
            rec.StrokeThickness = 1;
            return rec;
        }


    }
}
