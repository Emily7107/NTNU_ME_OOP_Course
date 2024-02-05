using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, date,weekday;
            int y, c,w;
            Console.WriteLine("請輸入年分:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入月分:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入日期:");
            date = int.Parse(Console.ReadLine());
            c = year / 100;
            y = year % 100;
            w = y + (y / 4) + (c / 4) - 2 * c + (26 * (month + 1) / 10) + date - 1;
            weekday = w % 7;
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("星期一");
                    break;
                case 2:
                    Console.WriteLine("星期二");
                    break;
                case 3:
                    Console.WriteLine("星期三");
                    break;
                case 4:
                    Console.WriteLine("星期四");
                    break;
                case 5:
                    Console.WriteLine("星期五");
                    break;
                case 6:
                    Console.WriteLine("星期六");
                    break;
                case 7:
                    Console.WriteLine("星期日");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadKey();

        }
    }
}
