using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using Figure.Tools;

namespace Figure.Models
{
    internal class Triangle : FigureBase
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        private bool CheckValidData(double firstSide, double secondSide, double thirdSide)
        {
            return ((firstSide + secondSide) > thirdSide) && 
                ((secondSide + thirdSide) > firstSide) &&
                ((firstSide + thirdSide) > secondSide);
        }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!CheckValidData(firstSide, secondSide, thirdSide))
                throw new ArgumentException("Sides value don't valid for triangle");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        protected override double P() => FirstSide + SecondSide + ThirdSide;

        protected override double S() => Math.Sqrt(P() * (P() - FirstSide) * (P() - SecondSide) * (P() - ThirdSide));

        public override FrameworkElement Draw()
        {
            int Side1 = MyConverter.CentimeterToPixel(this.FirstSide);
            int Side2 = MyConverter.CentimeterToPixel(this.SecondSide);
            int Side3 = MyConverter.CentimeterToPixel(this.ThirdSide);
            double y = (Math.Pow(Side1, 2) + Math.Pow(Side3, 2) - Math.Pow(Side2, 2)) / (2 * Side1);
            double x = Math.Sqrt(Math.Pow(Side3, 2) - Math.Pow(y, 2));
            System.Windows.Point a = new System.Windows.Point(0, 0);
            System.Windows.Point b = new System.Windows.Point(0, Side1);
            System.Windows.Point c = new System.Windows.Point((int)x, (int)y);
            Polygon polygon = new Polygon();
            polygon.Points.Add(a);
            polygon.Points.Add(b);
            polygon.Points.Add(c);
            polygon.Stroke = Brushes.Black;
            polygon.StrokeThickness = 1;
            return polygon;
        }
    }
}
