using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4_ver2
{
    class Quadrilateral
    {
        public Point[] ptArr = new Point[4];
        public static readonly double Tol = 1e-10;
        
        public bool rightangle()
        {
            if (ptArr[0].xCoord - ptArr[1].xCoord<Tol && ptArr[0].yCoord - ptArr[3].yCoord <Tol&& ptArr[1].yCoord - ptArr[2].yCoord<Tol && ptArr[2].xCoord -ptArr[3].xCoord<Tol)
                return true;
            else
                return false;
        }
        public bool equalLength()
        {
            double[] side = new double[4];
            for(int i=0;i<4;i++)
                side[i] = ptArr[i].Distance(ptArr[(i + 1) % 4]);

            if (Math.Abs(side[0]-side[1])<Tol && Math.Abs(side[1] - side[2]) < Tol && Math.Abs(side[2] - side[3]) < Tol&& Math.Abs(side[3] - side[0]) < Tol)
                return true;
            else
                return false;
        }
        public bool equalAngle()
        {
            double angA, angB, angC, angD;
            angA = angle(ptArr[3], ptArr[0], ptArr[1]);
            angB = angle(ptArr[0], ptArr[1], ptArr[2]);
            angC = angle(ptArr[1], ptArr[2], ptArr[3]);
            angD = angle(ptArr[2], ptArr[3], ptArr[0]);
            if (angA == angC && angB == angD)
                return true;
            else
                return false;
        }
        public bool paralleLine()
        {
            if ((ptArr[0].xCoord == ptArr[1].xCoord && ptArr[2].xCoord == ptArr[3].xCoord) || (ptArr[0].yCoord == ptArr[3].yCoord && ptArr[1].yCoord == ptArr[2].yCoord))
                return true;
            else
                return false;
        }
        public bool oneEqualLength()
        {
            double a, b, c, d;
            a = ptArr[0].Distance(ptArr[1]);
            b = ptArr[1].Distance(ptArr[2]);
            c = ptArr[2].Distance(ptArr[3]);
            d = ptArr[3].Distance(ptArr[0]);
            if ((a == b && c == d) || (a == d && b == c))
                return true;
            else
                return false;
        }

        public double angle(Point a,Point b,Point c)
        {
            double ang, va, vb, dot, cos;
            va = ptArr[0].Distance(ptArr[1]);
            vb = ptArr[0].Distance(ptArr[3]);
            dot = (a.xCoord - b.xCoord) * (c.xCoord - b.xCoord) + (a.yCoord - b.yCoord) * (c.yCoord - b.yCoord);
            cos = dot / (va * vb);
            ang = Math.Acos(cos) * 180 / Math.PI;
            return ang;
        }
        public double Area()
        {
            Triangle tri1 = new Triangle();
            for (int i = 0; i < 3; i++)
                tri1.ptArr[i] = new Point();
            tri1.ptArr[0] = ptArr[0];
            tri1.ptArr[1] = ptArr[1];
            tri1.ptArr[2] = ptArr[2];
            Triangle tri2 = new Triangle();
            for (int i = 0; i < 3; i++)
                tri2.ptArr[i] = new Point();
            tri2.ptArr[0] = ptArr[2];
            tri2.ptArr[1] = ptArr[3];
            tri2.ptArr[2] = ptArr[0];
            return tri1.Area() + tri2.Area();
        }
        public bool isSquare()
        {
            if (rightangle() && equalLength())
                return true;
            else
                return false;
        }
        public bool isRectangle()
        {
            if (rightangle() && !equalLength())
                return true;
            else
                return false;
        }
        public bool isDiamond()
        {
            if (!rightangle() && equalLength() && equalAngle())
                return true;
            else
                return false;

        }
        public bool isParallelogram()
        {
            if (!rightangle() && !equalLength() && equalAngle())
                return true;
            else
                return false;
        }
        public bool isTrapezoid()
        {
            if (!rightangle() && !equalAngle() && paralleLine())
                return true;
            else
                return false;
        }
        public bool isKite()
        {
            if (!rightangle() && !equalAngle() && !paralleLine()&& oneEqualLength())
                return true;
            else
                return false;
        }
        public bool isIrregular()
        {
            if (!rightangle() && !equalAngle() && !paralleLine() && !oneEqualLength())
                return true;
            else
                return false;
        }
    }
}
