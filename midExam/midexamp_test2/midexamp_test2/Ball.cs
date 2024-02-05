using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midexamp_test2
{
    class Ball:Shape3D,IRollable
    {
        new private static int amount;
        private double radius;
        public Ball():base()
        {
            geoType = ShapeType.Geo.BALL;
            radius = 0;
            amount++;
        }
        public Ball(double radius,ShapeType.Material mType):base(mType)
        {
            geoType = ShapeType.Geo.BALL;
            Radius = radius;
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
        public override double Volume()
        {
            return 4 * Math.PI * Math.Pow(radius, 3) / 3;
        }
        public override string ShapeProperty()
        {
            string str = "";
            str += string.Format("{0,8:F2}", "Ball");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8:F2}", "");
            str += "\t";
            str += Property();
            return str;
        }
        public double Distence()
        {
            return radius * radius;
        }
        public string RollShapeProperty()
        {
            return ShapeProperty() + string.Format("{0,8:F2}", Distence());
        }
    }
}
