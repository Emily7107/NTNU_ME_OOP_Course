using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens;
            Point point=new Point();
            Quadrilateral quad = new Quadrilateral();
            for(int i=0;i<4;i++)
                quad.ptArr[i] = new Point();
            
            while (true)
            {
                Console.WriteLine("請輸入四邊形的四個頂點座標，並計算其特性");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("(x" + (i + 1).ToString() + ",y" + (i + 1).ToString() + ") = ");
                    tokens = Console.ReadLine().Split(' ');
                    quad.ptArr[i].xCoord = double.Parse(tokens[0]);
                    quad.ptArr[i].yCoord = double.Parse(tokens[1]);
                }

                if (quad.isSquare())
                    Console.WriteLine("正方形");
                else if (quad.isRectangle())
                    Console.WriteLine("長方形");
                else if (quad.isDiamond())
                    Console.WriteLine("菱形");
                else if (quad.isParallelogram())
                    Console.WriteLine("平行四邊形");
                else if (quad.isTrapzoid())
                    Console.WriteLine("梯形");
                else if (quad.isKite())
                    Console.WriteLine("箏型");
                else
                    Console.WriteLine("不規則形");

                Console.WriteLine("Area=" + quad.Area().ToString());
                Console.WriteLine("Again?  ");
                String check = Console.ReadLine();
                if ((check != "y") && (check != "Y"))
                    break;
            }
            Console.WriteLine("End of Program!");
            Console.ReadKey();
        }
    }
}
