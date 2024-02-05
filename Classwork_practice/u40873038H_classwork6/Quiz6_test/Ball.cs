using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6_test
{
    class Ball
    {
        private static int amount;
        private double density;
        private double radius;

        public Ball()
        {
            density = 0;
            radius = 0;
            amount++;
        }
        public Ball(double density,double radius)
        {
            Density = density;
            Radius = radius;
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
        public double Volume()
        {
            return 4 * Math.PI * Math.Pow(radius, 3) / 3;
        }
        public double Weight()
        {
            return density * Volume();
        }
        public string Message()
        {
            string str = "";
            str += string.Format("{0,8}", "Ball");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8}", "");
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
