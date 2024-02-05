using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4_test
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimeter, area, radius;
            Triangle p = new Triangle();
            char again;
            string[] point;
            do
            {
                Console.WriteLine("請依序輸入三角形的三個頂點");
                for(int i=0;i<3;i++)
                {
                    Console.Write("(x" + (i + 1).ToString() + ",y" + (i + 1).ToString() + ")= ");
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
                    Console.WriteLine("Radius of Circumcircle={0}", radius);
                    if (p.isRight())
                        Console.WriteLine("This is a right triangle!");
                }
                else
                    Console.WriteLine("Not a Triangle, Please Input the new coordinate!");
                Console.Write("Again? ");
                again = char.Parse(Console.ReadLine());

            } while (again == 'y' || again == 'Y');
            Console.WriteLine("End of program!");
            Console.Read();
        }
    }
}
