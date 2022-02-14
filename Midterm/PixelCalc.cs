using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public static class PixelCalc
    {
        public static double CalculatePPI(int width, int height, int diagonalInInches)
        {
            double diagonalInPixels;
            diagonalInPixels = Math.Sqrt((width * width) + (height * height));
            return Math.Round((diagonalInPixels / diagonalInInches),2);
        }

        public static double CalculateDiagonalInPixels(int width, int height)
        {
            return Math.Round(Math.Sqrt((width * width) + (height * height)), 2);
        }
        public static double CalculateDotPitch(int width, int height, int diagonalInInches)
        {
            double diagonalInPixels, ppi;
            diagonalInPixels = Math.Sqrt((width * width) + (height * height));
            ppi = diagonalInPixels / diagonalInInches;
            return Math.Round(((1/ppi)*25.4), 4);
        }
    }
}
