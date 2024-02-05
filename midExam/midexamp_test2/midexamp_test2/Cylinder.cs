using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midexamp_test2
{
    class Cylinder:Shape3D,IRollable
    {
        new private static int amount;
        private double radius;
        private double high;
        public Cylinder() : base()
        {
            geoType = ShapeType.Geo.CYLINDER;
            radius = 0;
            high = 0;
            amount++;
        }
        public Cylinder(double radius,double high, ShapeType.Material mType) : base(mType)
        {
            geoType = ShapeType.Geo.CYLINDER;
            Radius = radius;
            High = high;
            amount++;
        }
        new public static int Amount
        {
            get { return amount; }
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
        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2)* high;
        }
        public override string ShapeProperty()
        {
            string str = "";
            str += string.Format("{0,8:F2}", "Cylinder");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8:F2}", high);
            str += "\t";
            str += Property();
            return str;
        }
        public double Distence()
        {
            return radius * high;
        }
        public string RollShapeProperty()
        {
            return ShapeProperty() + string.Format("{0,8:F2}", Distence());
        }
    }
}
