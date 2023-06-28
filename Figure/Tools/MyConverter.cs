using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Tools
{
    internal static class MyConverter
    {
        public static int CentimeterToPixel(double Centimeter)
        {
            return Convert.ToInt32(Centimeter * 37.8);
        }
    }
}
