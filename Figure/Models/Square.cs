using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Figure.Tools;

namespace Figure.Models
{
    internal class Square : FigureBase
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        protected override double P() => Side * 4;

        protected override double S() => Side * Side;

        public override FrameworkElement Draw()
        {
            System.Windows.Shapes.Rectangle rec = new System.Windows.Shapes.Rectangle();
            rec.Width = MyConverter.CentimeterToPixel(this.Side);
            rec.Height = MyConverter.CentimeterToPixel(this.Side);
            rec.Stroke = Brushes.Black;
            rec.StrokeThickness = 1;
            return rec;
        }
    }
}
