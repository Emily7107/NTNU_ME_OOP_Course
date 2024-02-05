using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork3
{
    class Quadrilateral
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        public double x3;
        public double y3;
        public double x4;
        public double y4;
        public const double Tol = 1e-10;

        public bool isSquare()
        {
            double a, b, c, d;
            a = sideLength(x1, y1, x2, y2);
            b = sideLength(x1, y1, x4, y4);
            c = sideLength(x3, y3, x4, y4);
            d = sideLength(x2, y2, x3, y3);
            if (a == b && b == c && c == d && isRectangle())
                return true;
            else
                return false;
        }
        public bool isRectangle()
        {
            if (x1 == x2 && y1 == y4 && y2 == y3 && x3 == x4)
                return true;
            else
                return false;
        }
        public bool isDiamond()
        {
            double a, b, c, d;
            a = sideLength(x1, y1, x2, y2);
            b = sideLength(x1, y1, x4, y4);
            c = sideLength(x3, y3, x4, y4);
            d = sideLength(x2, y2, x3, y3);
            if (a == b && b == c && c == d && isParallelogram())
                return true;
            else
                return false;

        }
        public bool isParallelogram()
        {
            double ang1, ang2, ang3, ang4;
            ang1 = angle(x2, y2, x1, y1, x4, y4);
            ang2 = angle(x1, y1, x2, y2, x3, y3);
            ang3 = angle(x2, y2, x3, y3, x4, y4);
            ang4 = angle(x3, y3, x4, y4, x1, y1);
            if (ang1 == ang3 && ang2 == ang4)
                return true;
            else
                return false;
        }
        public bool isTrapezoid()
        {
            double ang1, ang2, ang3, ang4;
            ang1 = angle(x2, y2, x1, y1, x4, y4);
            ang2 = angle(x1, y1, x2, y2, x3, y3);
            ang3 = angle(x2, y2, x3, y3, x4, y4);
            ang4 = angle(x3, y3, x4, y4, x1, y1);
            if ((ang1+ang2-180<Tol&&ang3+ang4-180<Tol) || (ang1 + ang4 - 180<Tol && ang3 + ang2 - 180<Tol))
                return true;
            else
                return false;
        }
        public bool isKite()
        {
            double a, b, c, d;
            a = sideLength(x1, y1, x2, y2);
            b = sideLength(x1, y1, x4, y4);
            c = sideLength(x3, y3, x4, y4);
            d = sideLength(x2, y2, x3, y3);
            if ((a == b && c == d) || (a == d && b == c))
                return true;
            else
                return false;
        }
        public bool isIrregular()
        {
            if (!isKite())
                return true;
            else
                return false;
        }
        public double angle(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double ang, va, vb, dot, cos;
            va = sideLength(ax, bx, ay, by);
            vb = sideLength(cx, bx, cy, by); ;
            dot = (ax - bx) * (cx - bx) + (ay - by) * (cy - by);
            cos = dot / (va * vb);
            ang = Math.Acos(cos) * 180 / Math.PI;
            return ang;
        }
        public double sideLength(double ax, double ay, double bx, double by)
        {
            double l = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
            return l;
        }
        public double Area()
        {
            double are;
            are = (x1 * y2 + x2 * y3 + x3 * y4 + x4 * y1 - y1 * x2 - y2 * x3 - y3 * x4 - y4 * x1) / 2;
            return Math.Abs(are);
        }
    }
}