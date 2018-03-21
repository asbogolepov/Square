using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public class Triangle
    {
        public static double PerimHalf(double a, double b, double c)
        {
            double result = 0.5 * (a + b + c);
            return result;
        }

        public static double SquareTriangle(double a, double b, double c)
        {
            double p = PerimHalf(a, b, c);
            return Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)),3);
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            bool isRight;
            if (a*a == b * b + c * c)
            {
                isRight = true;
            }
            else if (b*b == a * a + c * c)
            {
                isRight = true;
            }
            else if (c*c == a*a + b * b)
            {
                isRight = true;           
            }
            else
            {
                isRight = false;
            }

            return isRight;
        }
    }

    public class Circle
    {
        public static double SquareCircle(double r)
        {
            double pi = Math.PI;
            double s = Math.Round(2 * pi * r,3);
            return s;
        }
    }

    
}
