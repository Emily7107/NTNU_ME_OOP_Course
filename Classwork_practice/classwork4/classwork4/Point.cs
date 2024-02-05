using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4
{
    class Point
    {
        public double xCoord;
        public double yCoord;
        public double Distance(Point target)
        {

            double l = Math.Sqrt(Math.Pow(this.xCoord-target.xCoord, 2)+Math.Pow(this.yCoord-target.yCoord,2));
            return l;
        }

    }
}
