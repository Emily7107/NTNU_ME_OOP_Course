using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6_test
{
    class Pyramid
    {
        private static int amount;
        private double density;
        private double side;
        private double high;
        public Pyramid()
        {
            density = 0;
            side = 0;
            high = 0;
            amount++;
        }
        public Pyramid(double density, double side, double high)
        {
            Density = density;
            Side = side;
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
        public double Side
        {
            get { return side; }
            set
            {
                if (value < 0)
                    side = 0;
                else

                    side = value;
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
            return Math.Pow(side, 2) * high / 3;
        }
        public double Weight()
        {
            return density * Volume();
        }
        public string Message()
        {
            string str = "";
            str += string.Format("{0,8}", "Pyramid");
            str += "\t";
            str += string.Format("{0,8:F2}", side);
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
