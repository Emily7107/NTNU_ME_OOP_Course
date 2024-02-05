using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_test
{
    class Triangle
    {
        public double Point1X, Point1Y, Point2X, Point2Y, Point3X, Point3Y;
        public const double Tol = 1e-10;
        private double Length(double x1, double y1, double x2, double y2)
        {
            double l;
            l = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return l;
        }
        public bool isValid()
        {
            double a, b, c;
            a = Length(Point1X, Point1Y, Point2X, Point2Y);
            b = Length(Point2X, Point2Y, Point3X, Point3Y);
            c = Length(Point1X, Point1Y, Point3X, Point3Y);
            if (a + b > c && b + c > a && c + a > b)
                return true;
            else
                return false;
        }
        public double Perimeter()
        {
            double a, b, c;
            a = Length(Point1X, Point1Y, Point2X, Point2Y);
            b = Length(Point2X, Point2Y, Point3X, Point3Y);
            c = Length(Point1X, Point1Y, Point3X, Point3Y);
            return a + b + c;
        }
        public double Area(double s)
        {
            double a, b, c;
            a = Length(Point1X, Point1Y, Point2X, Point2Y);
            b = Length(Point2X, Point2Y, Point3X, Point3Y);
            c = Length(Point1X, Point1Y, Point3X, Point3Y);
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public double RadiusOfCircumcircle(double ar)
        {
            double a, b, c;
            a = Length(Point1X, Point1Y, Point2X, Point2Y);
            b = Length(Point2X, Point2Y, Point3X, Point3Y);
            c = Length(Point1X, Point1Y, Point3X, Point3Y);
            return (a * b * c) / (4 * ar);
        }
        public bool isRight()
        {
            double a, b, c;
            a = Length(Point1X, Point1Y, Point2X, Point2Y);
            b = Length(Point2X, Point2Y, Point3X, Point3Y);
            c = Length(Point1X, Point1Y, Point3X, Point3Y);
            if (Math.Abs(a * a + b * b - c * c) < Tol || Math.Abs(b * b + c * c - a * a) < Tol || Math.Abs(c * c + a * a - b * b) < Tol)
                return true;
            else
                return false;
        }
    }
}
