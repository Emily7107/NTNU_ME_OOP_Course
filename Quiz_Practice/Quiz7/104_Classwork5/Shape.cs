using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz6
{
    class Shape
    {
        protected static int _amount;
        protected double density;

        public Shape()
        {
            density = 0;
            _amount++;
        }
        public Shape(double density)
        {
            Density = density;
            _amount++;
        }
        public static int Amount
        {
            get { return _amount; }
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
        public virtual double Volume()
        {
            return 0;
        }
        public double Weight()
        {
            return density * Volume();
        }
        public virtual string ShapeProperty()
        {
            return "";
        }
        public string Property()
        {
            string str = "";
            str += string.Format("{0,8:F2}", density);
            str += '\t';
            str += string.Format("{0,8:F2}", Volume());
            str += '\t';
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }

    }
}
