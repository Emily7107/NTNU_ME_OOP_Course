using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month;
            int day;
            Console.WriteLine("請輸入年分:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入月份:");
            month = int.Parse(Console.ReadLine());
            if (month == 4 || month == 6 || month == 9 || month == 11)
                day = 30;
            else if (month == 2)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    day = 29;
                else
                    day = 28;
            }
            else
                day = 31;
            Console.WriteLine("{0}年{1}月有{2}天:", year, month, day);
            Console.ReadKey();
        }
    }
}
