using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u40873038H_Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle p = new Triangle();
            double pe, ar, rad;
            char again;
            string[] point;
            do
            {
                Console.WriteLine("請輸入三角形的三個頂點座標，並計算其特性");
                Console.Write("(x1,y1)= ");
                point = Console.ReadLine().Split(' ');
                p.Point1X = double.Parse(point[0]);
                p.Point1Y = double.Parse(point[1]);
                Console.Write("(x2,y2)= ");
                point = Console.ReadLine().Split(' ');
                p.Point2X = double.Parse(point[0]);
                p.Point2Y = double.Parse(point[1]);
                Console.Write("(x3,y3)= ");
                point = Console.ReadLine().Split(' ');
                p.Point3X = double.Parse(point[0]);
                p.Point3Y = double.Parse(point[1]);
                if (p.isValid())
                {
                    pe = p.Perimeter();
                    ar = p.Area(0.5 * pe);
                    rad = p.RadiusOfCircumcircle(ar);
                    Console.WriteLine("Perimeter={0}", pe);
                    Console.WriteLine("Area={0}", ar);
                    Console.WriteLine("Radius of Circumcircle={0}", rad);
                    if (p.isRight())
                        Console.WriteLine("直角三角形!");
                    else
                        Console.WriteLine("非直角三角形!");
                }
                else
                    Console.WriteLine("這三點不能組成三角形!");
                Console.WriteLine("Again?");
                again = char.Parse(Console.ReadLine());
            } while (again == 'Y' || again == 'y');
            Console.WriteLine("End of Program!");
            Console.Read();
        }
    }
}
