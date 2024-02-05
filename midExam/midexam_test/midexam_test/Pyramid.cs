using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midexam_test
{
    class Pyramid:Shape3D
    {
        new private static int amount;
        private double side;
        private double high;
        public Pyramid() : base()
        {
            geoType = ShapeType.Geo.CYLINDER;
            side = 0;
            high = 0;
            amount++;
        }
        public Pyramid(double side, double high, ShapeType.Material mType) : base(mType)
        {
            geoType = ShapeType.Geo.CYLINDER;
            Side = side;
            High = high;
            amount++;
        }
        new public static int Amount
        {
            get { return amount; }
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
        public override double Volume()
        {
            return Math.Pow(side, 2) * high/3;
        }
        public override string ShapeProperty()
        {
            string str = "";
            str += string.Format("{0,8:F2}", "Pyramid");
            str += "\t";
            str += string.Format("{0,8:F2}", side);
            str += "\t";
            str += string.Format("{0,8:F2}", high);
            str += "\t";
            str += Property();
            return str;
        }
    }
}

