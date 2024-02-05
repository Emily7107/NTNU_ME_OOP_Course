using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u40873038H_Quiz6
{
    class Pyramid
    {
        private static int amount = 0;
        private double density, side, high;
        //Constructors
        public Pyramid(double density, double side, double high)
        {
            Density = density;
            Side = side;
            High = high;
            amount++;
        }
        //ReadOnly Attribute
        public static int Amount
        {
            get { return amount; }
        }
        //Attribute
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
        //Methods
        public double Valume()
        {
            return (this.side * this.side * this.high) / 3;
        }
        public double Weight()
        {
            return Valume() * this.density;
        }
        public string ShowMessage()
        {
            string str = "";
            str += string.Format("{0,8}", "Pyramid");
            str += "\t";
            str += string.Format("{0,8:F2}", side);
            str += "\t";
            str += string.Format("{0,8}", high);
            str += "\t";
            str += string.Format("{0,8:F2}", density);
            str += "\t";
            str += string.Format("{0,8:F2}", Valume());
            str += "\t";
            str += string.Format("{0,8:F2}", Weight());
            str += "\r\n";
            return str;
        }
    }
}
