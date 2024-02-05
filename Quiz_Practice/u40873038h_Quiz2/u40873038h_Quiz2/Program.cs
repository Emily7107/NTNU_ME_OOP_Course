using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u40873038h_Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            int r;
            int sum = 0;
            int sum2 = 0;
            int count = 0;
            Console.WriteLine("S=(100000*a+10000*b+100*c+100*d+10*e+f,0<=a,b,c,d,e,f<=9");
            Console.Write("請輸入一個整數n:");
            n = int.Parse(Console.ReadLine());
            Console.Write("請輸入要印出幾個數字:");
            k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int temp;
                int num = 0;
                temp = i;
                while (temp != 0)
                {
                    r = temp % 100;
                    temp = temp / 100;
                    num += r * r * r;
                }
                if (num == i)
                {
                    Console.WriteLine("{0}", i);
                    sum += i;
                    count++;
                    if (count == k)
                        Console.WriteLine("====以上是你要求的數字=====");
                }

            }
            if (count < k)
                Console.WriteLine("要求數值超過符合的數字個數");
            Console.WriteLine("總和:{0}", sum);
            Console.ReadKey();
        }
    }
}
