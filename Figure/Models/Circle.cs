using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using Figure.Tools;

namespace Figure.Models
{
    internal class Circle : FigureBase
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        protected override double P() => 2 * Math.PI * R;

        protected override double S() => Math.PI * R * R;

        public override FrameworkElement Draw()
        {
            Ellipse el = new Ellipse();
            el.Width = MyConverter.CentimeterToPixel(this.R);
            el.Height = MyConverter.CentimeterToPixel(this.R);
            el.Stroke = Brushes.Black;
            el.StrokeThickness = 1;
            return el;
        }
    }
}
