﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz6;

namespace _106_Quiz6
{
    class Cylinder:Shape
    {
        new private static int _amount;
        private double _radius;
        private double _height;
        private static double _pi = 3.1415926;
        public Cylinder():base()
        {
            _radius = 0;
            _height = 0;
            _amount++;
        }
        public Cylinder(double radius, double height,double density):base(density)
        {
            Radius = radius;
            Height = height;
            _amount++;
        }
        new public static int Amount
        {
            get { return _amount; }
        }
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    _radius = 0;
                else
                    _radius = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    _height = 0;
                else
                    _height = value;
            }
        }
        public override double Volume()
        {
            return _pi * _radius * _radius * _height;
        }

        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Cylinder");
            str += '\t';
            str += string.Format("{0,8:F2}", _radius);
            str += '\t';
            str += string.Format("{0,8:F2}", _height);
            str += '\t';
            str += Property();
            return str;
        }
    }
}
