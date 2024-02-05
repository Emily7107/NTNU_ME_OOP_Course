using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midexamp_test2
{
    class Cube:Shape3D
    {
        new private static int amount;
        private double side;
        public Cube() : base()
        {
            geoType = ShapeType.Geo.CUBE;
            side = 0;
            amount++;
        }
        public Cube(double side, ShapeType.Material mType) : base(mType)
        {
            geoType = ShapeType.Geo.CUBE;
            Side = side;
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
        public override double Volume()
        {
            return Math.Pow(side, 3);
        }
        public override string ShapeProperty()
        {
            string str = "";
            str += string.Format("{0,8:F2}", "Cube");
            str += "\t";
            str += string.Format("{0,8:F2}", side);
            str += "\t";
            str += string.Format("{0,8:F2}", "");
            str += "\t";
            str += Property();
            return str;
        }
    }
}
