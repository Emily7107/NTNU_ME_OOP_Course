using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle p;
            p = new Triangle();
            string[] point;
            char again;
            double pe,ar,rad;
            do
            {
                Console.WriteLine("請輸入三角形的三個頂點座標，並計算其特性");
                Console.Write("(x1,y1)=");
                point = Console.ReadLine().Split(' ');
                p.x1 = double.Parse(point[0]);
                p.y1 = double.Parse(point[1]);
                Console.Write("(x2,y2)=");
                point = Console.ReadLine().Split(' ');
                p.x2 = double.Parse(point[0]);
                p.y2 = double.Parse(point[1]);
                Console.Write("(x3,y3)=");
                point = Console.ReadLine().Split(' ');
                p.x3 = double.Parse(point[0]);
                p.y3 = double.Parse(point[1]);
                if (p.isValid())
                {
                    pe = p.Perimeter();
                    ar = p.Area(0.5*pe);
                    rad = p.RadiusOfCircumcircle(ar);
                    Console.WriteLine("Perimeter={0}", pe);
                    Console.WriteLine("Area={0}", ar);
                    Console.WriteLine("Radius of Circumircle={0}", rad);
                    if (p.isRight())
                        Console.WriteLine("直角三角形!");
                    else
                        Console.WriteLine("非直角三角形!");
                }
                else
                    Console.WriteLine("這三點不能組成三角形!");
                Console.WriteLine("Again?");
                again = char.Parse(Console.ReadLine());
            } while (again == 'y');
            Console.WriteLine("End of Program!");
            Console.ReadKey();
        }
    }
    class Triangle
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        public double x3;
        public double y3;

        public bool isValid()
        {
            double a, b, c;
            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            if (a + b > c && b + c > a && c + a > b)
                return true;
            else
                return false;
        }
        public double Perimeter()
        {
            double a, b, c;
            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            return a + b + c;

        }
        public double Area(double s)
        {
            double a, b, c;
            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public double RadiusOfCircumcircle(double ar)
        {
            double a, b, c;
            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            return (a * b * c) / (4 * ar);
        }
        public bool isRight()
        {
            double a, b, c;
            a = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
            b = Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2);
            c = Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2);
            if (a + b == c || b + c == a || a + c == b)
                return true;
            else
                return false;
        }
    }
}
