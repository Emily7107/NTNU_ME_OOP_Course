using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u40873038H_Quiz6
{
    class Cylinder
    {
        private static int amount = 0;
        private double density, radius,high;
        //Constructors
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
        //Methods
        public double Valume()
        {
            return Math.Pow(radius, 2) * Math.PI * this.high;
        }
        public double Weight()
        {
            return Valume() * density;
        }
        public string ShowMessage()
        {
            string str = "";
            str += string.Format("{0,8}", "Cylinder");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
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
