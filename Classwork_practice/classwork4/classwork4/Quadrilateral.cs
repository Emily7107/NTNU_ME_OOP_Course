using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4
{
    class Quadrilateral
    {
        public Point[] ptArr = new Point[4];
        public const double Tol = 1e-10;
        private double Angle(Point A, Point B, Point C)
        {
            double a = B.Distance(A);
            double b = C.Distance(A);
            double c = B.Distance(C);
            return Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
        }
        private bool isEqualAngle()
        {
            double angle1 = Angle(ptArr[3],ptArr[0],ptArr[1]);
            double angle2 = Angle(ptArr[0],ptArr[1],ptArr[2]);
            double angle3 = Angle(ptArr[1],ptArr[2],ptArr[3]);
            double angle4 = Angle(ptArr[2],ptArr[3],ptArr[0]);
            if (Math.Abs(angle1 - 90) < Tol && Math.Abs(angle2 - 90) < Tol && Math.Abs(angle3 - 90) < Tol && Math.Abs(angle4 - 90) < Tol)
                return true;
            else
                return false;
        }
        private bool isEqualSide()
        {
            double s1 = ptArr[0].Distance(ptArr[1]);
            double s2 = ptArr[1].Distance(ptArr[2]);
            double s3 = ptArr[2].Distance(ptArr[3]);
            double s4 = ptArr[3].Distance(ptArr[0]);
            if (Math.Abs(s1 - s2) < Tol && Math.Abs(s2 - s3) < Tol && Math.Abs(s3 - s4) < Tol && Math.Abs(s4 - s1) < Tol)
                return true;
            else
                return false;
        }
        private bool isEqualOppsiteAngle()
        {
            double angle1 = Angle(ptArr[3], ptArr[0], ptArr[1]);
            double angle2 = Angle(ptArr[0], ptArr[1], ptArr[2]);
            double angle3 = Angle(ptArr[1], ptArr[2], ptArr[3]);
            double angle4 = Angle(ptArr[2], ptArr[3], ptArr[0]);
            if (Math.Abs(angle1 - angle3) < Tol && Math.Abs(angle2 - angle4) < Tol)
                return true;
            else
                return false;
        }
        private bool hasParallelSide()
        {
            double angle1 = Angle(ptArr[3], ptArr[0], ptArr[1]);
            double angle2 = Angle(ptArr[0], ptArr[1], ptArr[2]);
            double angle3 = Angle(ptArr[1], ptArr[2], ptArr[3]);
            double angle4 = Angle(ptArr[2], ptArr[3], ptArr[0]);
            if (Math.Abs(angle1 + angle2 - 180) < Tol && Math.Abs(angle3 + angle4 - 180) < Tol)
                return true;
            else if (Math.Abs(angle1 + angle4 - 180) < Tol && Math.Abs(angle2 + angle3 - 180) < Tol)
                return true;
            else
                return false;
        }
        private bool hasEqualAdjacentSide()
        {
            double s1 = ptArr[0].Distance(ptArr[1]);
            double s2 = ptArr[1].Distance(ptArr[2]);
            double s3 = ptArr[2].Distance(ptArr[3]);
            double s4 = ptArr[3].Distance(ptArr[0]);
            if (Math.Abs(s1 - s2) < Tol)
                return true;
            else if (Math.Abs(s2 - s3) < Tol)
                return true;
            else if (Math.Abs(s3 - s4) < Tol)
                return true;
            else if (Math.Abs(s4 - s1) < Tol)
                return true;
            else
                return false;
        }
        public bool isSquare()
        {
            if (isEqualAngle() && isEqualSide())
                return true;
            else
                return false;
        }
        public bool isRectangle()
        {
            if (isEqualAngle() && !isEqualSide())
                return true;
            else
                return false;
        }
        public bool isDiamond()
        {
            if (!isEqualAngle() && isEqualOppsiteAngle() && isEqualSide())
                return true;
            else
                return false;
        }
        public bool isParallelogram()
        {
            if (!isEqualAngle() && isEqualOppsiteAngle() && !isEqualSide())
                return true;
            else
                return false;
        }
        public bool isTrapzoid()
        {
            if (!isEqualAngle() && !isEqualOppsiteAngle() && hasParallelSide())
                return true;
            else
                return false;
        }
        public bool isKite()
        {
            if (!isEqualAngle() && !isEqualOppsiteAngle() && !hasParallelSide() && hasEqualAdjacentSide())
                return true;
            else
                return false;
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
    }
}
