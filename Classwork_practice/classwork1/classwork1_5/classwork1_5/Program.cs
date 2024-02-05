using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day,date;
            Console.WriteLine("請輸入年分:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入月分:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入日期:");
            date = int.Parse(Console.ReadLine());
            Console.WriteLine("日期是否合法:");
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                day = 30;
                if (0<=date&&date<=day)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else if (month == 2)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    day = 29;
                    if (0 <= date && date <= day)
                        Console.WriteLine("True");
                    else
                        Console.WriteLine("False");
                }
                else
                {
                    day = 28;
                    if (0 <= date && date <= day)
                        Console.WriteLine("True");
                    else
                        Console.WriteLine("False");
                }
                    
            }
            else
            {
                day = 31;
                if (0 <= date && date <= day)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            Console.ReadKey();  
        }
    }
}
