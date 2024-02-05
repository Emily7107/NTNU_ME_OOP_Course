using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork3_ver2
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
        public int checkshape()
        {
            if (rightangle())
            {
                if (equalLength())
                    return 1;
                else
                    return 2;
            }
            else
            {
                if(equalAngle())
                {
                    if (equalLength())
                        return 3;
                    else
                        return 4;
                }
                else
                {
                    if (paralleLine())
                        return 5;
                    else
                    {
                        if (oneEqualLength())
                            return 6;
                        else
                            return 7;
                    }
                }
            }

        }
        public bool rightangle()
        {
            if (x1 == x2 && y1 == y4 && y2 == y3 && x3 == x4)
                return true;
            else
                return false;
        }
        public bool equalLength()
        {
            double a, b, c, d;
            a = sideLength(x1, y1, x2, y2);
            b = sideLength(x1, y1, x4, y4);
            c = sideLength(x3, y3, x4, y4);
            d = sideLength(x2, y2, x3, y3);
            if (a == b && b == c && c == d)
                return true;
            else
                return false;
        }
        public bool equalAngle()
        {
            double angA, angB, angC, angD;
            angA = angle(x2, y2, x1, y1, x4, y4);
            angB = angle(x1, y1, x2, y2, x3, y3);
            angC = angle(x2, y2, x3, y3, x4, y4);
            angD = angle(x3, y3, x4, y4, x1, y1);
            if (angA == angC && angB == angD)
                return true;
            else
                return false;
        }
        public bool paralleLine()
        {
            if ((x1 == x2 && x3 == x4) || (y1 == y4 && y2 == y3))
                return true;
            else
                return false;
        }
        public bool oneEqualLength()
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
        public double sideLength(double ax, double ay, double bx, double by)
        {
            double l = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
            return l;
        }
        public double angle(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double ang, va, vb, dot, cos;
            va = sideLength(ax, ay, bx, by);
            vb = sideLength(cx, cy, bx, by); ;
            dot = (ax - bx) * (cx - bx) + (ay - by) * (cy - by);
            cos = dot / (va * vb);
            ang = Math.Acos(cos) * 180 / Math.PI;
            return ang;
        }
        public double Area()
        {
            double are;
            are = (x1 * y2 + x2 * y3 + x3 * y4 + x4 * y1 - y1 * x2 - y2 * x3 - y3 * x4 - y4 * x1) / 2;
            return Math.Abs(are);
        }

    }
}
