using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Figure.Tools
{
    internal abstract class FigureBase
    {
        protected abstract double S();

        protected abstract double P();

        public abstract FrameworkElement Draw();

        public string Info()
        {
            return $"Периметр = {P()} Площадь = {S()}";
        }
    }
}
