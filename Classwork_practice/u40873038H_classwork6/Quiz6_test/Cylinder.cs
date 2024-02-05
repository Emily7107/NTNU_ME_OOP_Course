using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6_test
{
    class Cylinder
    {
        private static int amount;
        private double density;
        private double radius;
        private double high;

        public Cylinder()
        {
            density = 0;
            radius = 0;
            high = 0;
            amount++;
        }
        public Cylinder(double density, double radius,double high)
        {
            Density = density;
            Radius = radius;
            High = high;
            amount++;
        }

        public static int Amount
        {
            get { return amount; }
        }
        public double Density
        {
            get { return density; }
            set
            {
                if (value < 0)
                    density = 0;
                else
                    density = value;
            }
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                    radius = 0;
                else
                    radius = value;
            }
        }
        public double High
        {
            get { return high; }
            set
            {
                if (value < 0)
                    high = 0;
                else
                    high = value;
            }
        }
        public double Volume()
        {
            return Math.Pow(radius, 2)*Math.PI*high;
        }
        public double Weight()
        {
            return density * Volume();
        }
        public string Message()
        {
            string str = "";
            str += string.Format("{0,8}", "Cylinder");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8:F2}", high);
            str += "\t";
            str += string.Format("{0,8:F2}", density);
            str += "\t";
            str += string.Format("{0,8:F2}", Volume());
            str += "\t";
            str += string.Format("{0,8:F2}", Weight());
            str += "\r\n";
            return str;
        }
    }
}
