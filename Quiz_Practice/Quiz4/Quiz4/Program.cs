using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle p=new Triangle();
            string[] point;
            char again;
            double perimeter, area, radius;
            do
            {
                Console.WriteLine("請輸入三角形的三個頂點座標，並計算其特性");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("(x" + (i + 1).ToString() + ",y" + (i + 1).ToString() + ") = ");
                    point = Console.ReadLine().Split(' ');
                    p.x[i] = double.Parse(point[0]);
                    p.y[i] = double.Parse(point[1]);
                }
                if (p.isValid())
                {
                    perimeter = p.Perimeter();
                    area = p.Area(0.5 * perimeter);
                    radius = p.RadiusOfCircumcircle(area);
                    Console.WriteLine("Perimeter={0}", perimeter);
                    Console.WriteLine("Area={0}", area);
                    Console.WriteLine("Radius of Circumircle={0}", radius);
                    if (p.isRight())
                        Console.WriteLine("This is a right triangle!");
                }
                else
                    Console.WriteLine("Not a Triangle, Plwase Input the new coordinates!"); 
                Console.Write("Again? ");
                again = char.Parse(Console.ReadLine());
            } while (again == 'y' || again == 'Y');
            Console.WriteLine("End of Program!");
            Console.Read();
        }
    }
 }


