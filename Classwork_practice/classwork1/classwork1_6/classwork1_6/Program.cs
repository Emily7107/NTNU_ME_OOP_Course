using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] enter;
            int ys, ms, ds;
            int ye, me, de;
            int y1, m1, d1;
            int y2, m2, d2;
            Console.Write("請輸入起始年分: ");
            ys = int.Parse(Console.ReadLine());
            Console.Write("請輸入起始月分: ");
            ms = int.Parse(Console.ReadLine());
            Console.Write("請輸入起始日期: ");
            ds = int.Parse(Console.ReadLine());
            Console.Write("請輸入結束年分: ");
            ye = int.Parse(Console.ReadLine());
            Console.Write("請輸入結束月分: ");
            me = int.Parse(Console.ReadLine());
            Console.Write("請輸入結束日期: ");
            de = int.Parse(Console.ReadLine());
            if ((ys > ye) || ((ys == ye) && (ms > me)) || ((ys == ye) && (ms == me) && (ds > de)))
                Console.WriteLine("Error input");
            else
            {
                m1 = (ms + 9) % 12;
                y1 = ys - m1 / 10;
                d1 = 365 * y1 + y1 / 4 - y1 / 100 + y1 / 400 + (m1 * 306 + 5) / 10 + (ds - 1);
                m2 = (me + 9) % 12;
                y2 = ye - m2 / 10;
                d2 = 365 * y2 + y2 / 4 - y2 / 100 + y2 / 400 + (m2 * 306 + 5) / 10 + (de - 1);
                Console.WriteLine("間隔日數為:{0}", d2 - d1);
            }
            Console.ReadKey();
        }
    }
}
