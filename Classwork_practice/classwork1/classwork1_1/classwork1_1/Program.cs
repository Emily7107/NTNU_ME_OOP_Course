using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100~999之間的阿姆斯壯數有:");
            int num=100;
            for(num=100;num<=999;num++)
            {
                int temp;
                int count = 0;
                int sum = 0;
                temp = num;
                while(temp!=0)
                {
                    count = temp % 10;
                    temp = temp / 10;
                    sum += count*count*count;
                }
                if (sum == num)
                    Console.WriteLine("{0}", num);
            }
            Console.ReadKey();
        }
    }
}
