using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4_ver2
{
    class Triangle
    {
        public Point[] ptArr = new Point[3];

        public bool isValid()
        {
            double a, b, c;
            a = ptArr[0].Distance(ptArr[1]);
            b = ptArr[1].Distance(ptArr[2]);
            c = ptArr[2].Distance(ptArr[0]);
            if (a + b > c && b + c > a && c + a > b)
                return true;
            else
                return false;
        }
        public double Perimeter()
        {
            double a, b, c;
            a = ptArr[0].Distance(ptArr[1]);
            b = ptArr[1].Distance(ptArr[2]);
            c = ptArr[2].Distance(ptArr[0]);
            return a + b + c;

        }
        public double Area()
        {
            double a, b, c,s;
            a = ptArr[0].Distance(ptArr[1]);
            b = ptArr[1].Distance(ptArr[2]);
            c = ptArr[2].Distance(ptArr[0]);
            s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public double RadiusOfCircumcircle(double ar)
        {
            double a, b, c;
            a = ptArr[0].Distance(ptArr[1]);
            b = ptArr[1].Distance(ptArr[2]);
            c = ptArr[2].Distance(ptArr[0]);
            return (a * b * c) / (4 * ar);
        }
        public bool isRight()
        {
            double a, b, c;
            a = ptArr[0].Distance(ptArr[1]);
            b = ptArr[1].Distance(ptArr[2]);
            c = ptArr[2].Distance(ptArr[0]);
            if (a + b == c || b + c == a || a + c == b)
                return true;
            else
                return false;
        }
    }

}
