using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u40873038H_Quiz6
{
    class Ball
    {
        private static int amount = 0;
        private double density,radius;
        //Constructors
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
        //Methods
        public double Valume()
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        }
        public double Weight()
        {
            return Valume() * density;
        }
        public string ShowMessage()
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
            str += string.Format("{0,8:F2}", Valume());
            str += "\t";
            str += string.Format("{0,8:F2}",Weight());
            str += "\r\n";
            return str;
        }
    }
}
