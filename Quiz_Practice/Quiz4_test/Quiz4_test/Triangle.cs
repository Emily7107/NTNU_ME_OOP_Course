using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4_test
{
    class Triangle
    {
        public double[] x = new double[3];
        public double[] y = new double[3];
        public const double Tol = 1e-10;
        public void Length(double[]side)
        {
            for (int i = 0; i < side.Length; i++)
                side[i] = Math.Sqrt(Math.Pow(x[i] - x[(i + 1) % 3], 2) + Math.Pow(y[i] - y[(i + 1) % 3], 2));
        }
        public bool isValid()
        {
            double[] side = new double[3];
            Length(side);
            if (side[0] + side[1] - side[2] > Tol && side[1] + side[2] - side[0] > Tol && side[2] + side[0] - side[1] > Tol)
                return true;
            else
                return false;
        }
        public double Perimeter()
        {
            double[] side = new double[3];
            Length(side);
            return side[0] + side[1] + side[2];
        }
        public double Area(double s)
        {
            double[] side = new double[3];
            Length(side);
            return Math.Sqrt(s * (s - side[0]) * (s - side[1]) * (s - side[2]));
        }
        public double RadiusOfCircumcircle(double area)
        {
            double[] side = new double[3];
            Length(side);
            return (side[0] *side[1]* side[2]) / (4 * area);
        }
        public bool isRight()
        {
            double[] side = new double[3];
            Length(side);
            if (side[0] * side[0] + side[1] * side[1] - side[2] * side[2] < Tol || side[1] * side[1] + side[2] * side[2] - side[0] * side[0] < Tol || side[2] * side[2] + side[0] * side[0] - side[1] * side[1] < Tol)
                return true;
            else
                return false;
        }
    }
}
