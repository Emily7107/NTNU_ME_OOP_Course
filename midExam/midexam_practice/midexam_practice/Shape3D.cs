using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midexam_practice
{
    public static class ShapeType
    {
        public enum Geo
        {
            UNKNOWN=-1,BALL=0,CUBE,CYLINDER,PYRAMID
        };
        public enum Material
        {
            UNKNOWN=-1,Al=0,Fe,Pb
        };
    }
    abstract class Shape3D
    {
        protected static int amount;
        protected ShapeType.Material materialType;
        protected ShapeType.Geo geoType;
        public Shape3D()
        {
            materialType = ShapeType.Material.UNKNOWN;
            amount++;
        }
        public Shape3D(ShapeType.Material mType)
        {
            materialType = mType;
            amount++;
        }
        public static int Amount
        {
            get { return amount; }
        }
        public ShapeType.Material MaterialType
        {
            get { return materialType; }
        }
        public ShapeType.Geo GeoType
        {
            get { return geoType; }
        }
        public double Density()
        {
            return MaterialTable.Density(materialType);
        }
        public abstract double Volume();
        public double Weight()
        {
            return Density() * Volume();
        }
        public abstract string ShapeProperty();
        public string Property()
        {
            string str = "";
            str += string.Format("{0,8:F2}", Density());
            str += "\t";
            str += string.Format("{0,8:F2}", Volume());
            str += "\t";
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
    }
}
