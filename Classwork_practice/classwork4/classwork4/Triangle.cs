using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4
{
    class Triangle
    {
        public Point[] ptArr = new Point[3];

        public double Perimeter()
        {

            double s1 = ptArr[0].Distance(ptArr[1]);
            double s2 = ptArr[1].Distance(ptArr[2]);
            double s3 = ptArr[2].Distance(ptArr[0]);

            return (s1 + s2 + s3);
        }
        public double Area()
        {
            double s1 = ptArr[0].Distance(ptArr[1]);
            double s2 = ptArr[1].Distance(ptArr[2]);
            double s3 = ptArr[2].Distance(ptArr[0]);
            double s = (s1 + s2 + s3) / 2;
            return Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
        }
        public bool isValid()
        {
            double s1 = ptArr[0].Distance(ptArr[1]);
            double s2 = ptArr[1].Distance(ptArr[2]);
            double s3 = ptArr[2].Distance(ptArr[0]);
            if ((s1 + s2 <= s3) || (s2 + s3 <= s1) || (s1 + s3 <= s2))
                return false;
            return true;
        }
        public bool isRight()
        {
            double s1 = ptArr[0].Distance(ptArr[1]);
            double s2 = ptArr[1].Distance(ptArr[2]);
            double s3 = ptArr[2].Distance(ptArr[0]);
            if ((s1 * s1 + s2 * s2 == s3 * s3) || (s2 * s2 + s3 * s3 == s1 * s1) || (s1 * s1 + s3 * s3 == s2 * s2))
                return true;
            return false;
        }
        public double RadiusOfCircumcircle()
        {
            double s1 = ptArr[0].Distance(ptArr[1]);
            double s2 = ptArr[1].Distance(ptArr[2]);
            double s3 = ptArr[2].Distance(ptArr[0]);
            double CosAlpha = (s2 * s2 + s3 * s3 - s1 * s1) / (2 * s2 * s3);
            double SinAlpha = Math.Sqrt(1 - CosAlpha * CosAlpha);
            return 0.5 * s1 / SinAlpha;
        }

    }
}
