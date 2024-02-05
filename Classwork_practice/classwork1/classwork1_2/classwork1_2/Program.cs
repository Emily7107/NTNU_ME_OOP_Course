using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("請輸入年分:");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine("閏年\n");
            else if (year % 400 == 0)
                Console.WriteLine("閏年\n");
            else
                Console.WriteLine("平年\n");
            Console.ReadKey();
        }
    }
}
