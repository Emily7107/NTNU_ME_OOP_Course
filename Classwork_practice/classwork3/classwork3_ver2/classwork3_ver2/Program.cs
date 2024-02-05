using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork3_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral p;
            p = new Quadrilateral();
            string[] point;
            char again;
            double are;
            do
            {
                Console.WriteLine("請輸入四邊形的四個頂點座標，並計算其特性");
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
                Console.Write("(x4,y4)=");
                point = Console.ReadLine().Split(' ');
                p.x4 = double.Parse(point[0]);
                p.y4 = double.Parse(point[1]);
                switch(p.checkshape())
                {
                    case 1:
                        Console.WriteLine("正方形");
                        break;
                    case 2:
                        Console.WriteLine("長方形");
                        break;
                    case 3:
                        Console.WriteLine("菱形");
                        break;
                    case 4:
                        Console.WriteLine("平行四邊形");
                        break;
                    case 5:
                        Console.WriteLine("梯形");
                        break;
                    case 6:
                        Console.WriteLine("箏形");
                        break;
                    case 7:
                        Console.WriteLine("不規則四邊形");
                        break;
                    default:
                        Console.WriteLine("ERRO!");
                        break;
                }
               
                are = p.Area();
                Console.WriteLine("Area={0}", are);
                Console.WriteLine("Again?");
                again = char.Parse(Console.ReadLine());
            } while (again == 'y');
            Console.WriteLine("End of Program!");
            Console.ReadKey();
        }
    }
}
