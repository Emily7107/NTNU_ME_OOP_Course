using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral p;
            p = new Quadrilateral();
            for (int i = 0; i < 4; i++)
                p.ptArr[i] = new Point();
            string[] point;
            char again;
            double are;

            do
            {
                Console.WriteLine("請輸入四邊形的四個頂點座標，並計算其特性");
                for(int i=0;i<4;i++)
                {
                    Console.Write("(x" + (i + 1).ToString() + ",y" + (i + 1).ToString() + ")= ");
                    point = Console.ReadLine().Split(' ');
                    Point dot = new Point();
                    dot.xCoord = double.Parse(point[0]);
                    dot.yCoord = double.Parse(point[1]);
                    p.ptArr[i] = dot;
                }

                if (p.isSquare())
                    Console.WriteLine("正方形");
                else if (p.isRectangle())
                    Console.WriteLine("長方形");
                else if (p.isDiamond())
                    Console.WriteLine("菱形");
                else if (p.isParallelogram())
                    Console.WriteLine("平行四邊形");
                else if (p.isTrapezoid())
                    Console.WriteLine("梯形");
                else if (p.isKite())
                    Console.WriteLine("箏形");
                else if (p.isIrregular())
                    Console.WriteLine("不規則四邊形");
                else
                    Console.WriteLine("未知形狀");
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
