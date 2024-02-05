using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u40873038h_classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            int end=1;
            do
            {
                Console.WriteLine("================");
                Console.WriteLine("請選擇要執行的程式:");
                Console.WriteLine("1.classwork1_1");
                Console.WriteLine("2.classwork1_2");
                Console.WriteLine("3.classwork1_3");
                Console.WriteLine("4.classwork1_4");
                Console.WriteLine("5.classwork1_5");
                Console.WriteLine("6.classwork1_1");
                Console.WriteLine("0.停止程式");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        classwork1_1();
                        break;
                    case 2:
                        classwork1_2();
                        break;
                    case 3:
                        classwork1_3();
                        break;
                    case 4:
                        classwork1_4();
                        break;
                    case 5:
                        classwork1_5();
                        break;
                    case 6:
                        classwork1_6();
                        break;
                    case 0:
                        end = 0;
                        break;
                    default:
                        Console.WriteLine("ERRO!");
                        break;
                }
            } while (end != 0) ;
            Console.WriteLine("End of program!");
            Console.ReadKey();
        }
        static void classwork1_1()
        {
            Console.WriteLine("100~999之間的阿姆斯壯數有:");
            int num = 100;
            for (num = 100; num <= 999; num++)
            {
                int temp;
                int count = 0;
                int sum = 0;
                temp = num;
                while (temp != 0)
                {
                    count = temp % 10;
                    temp = temp / 10;
                    sum += count * count * count;
                }
                if (sum == num)
                    Console.WriteLine("{0}", num);
            }
            Console.ReadKey();
        }
        static void classwork1_2()
        {
            int year;
            Console.WriteLine("請輸入年分:");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine("閏年");
            else if (year % 400 == 0)
                Console.WriteLine("閏年");
            else
                Console.WriteLine("平年");
            Console.ReadKey();
        }
        static void classwork1_3()
        {
            string[] enter;
            int year, month;
            int day;
            Console.WriteLine("請輸入年分、月份(請用空格隔開):");
            enter=Console.ReadLine().Split(' ');
            year = int.Parse(enter[0]);
            month = int.Parse(enter[1]);
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
            Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
            Console.ReadKey();
        }
        static void classwork1_4()
        {
            string[] enter;
            int year, month, date, weekday;
            int y, c, w;
            Console.WriteLine("請輸入年月日(年月日以空格隔開):");
            enter = Console.ReadLine().Split(' ');
            year = int.Parse(enter[0]);
            month = int.Parse(enter[1]);
            date = int.Parse(enter[2]);
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
        static void classwork1_5()
        {
            string[] enter;
            int year, month, day, date;
            Console.WriteLine("請輸入年月日(年月日以空格隔開):");
            enter = Console.ReadLine().Split(' ');
            year = int.Parse(enter[0]);
            month = int.Parse(enter[1]);
            date = int.Parse(enter[2]);
            Console.WriteLine("日期是否合法:");
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                day = 30;
                if (0 <= date && date <= day)
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
        static void classwork1_6()
        {
            string[] enter;
            int ys, ms, ds;
            int ye, me, de;
            int y1, m1, d1;
            int y2, m2, d2;
            Console.WriteLine("請輸入起始年月日(年月日以空格隔開):");
            enter = Console.ReadLine().Split(' ');
            ys = int.Parse(enter[0]);
            ms = int.Parse(enter[1]);
            ds = int.Parse(enter[2]);
            Console.WriteLine("請輸入結束年月日(年月日以空格隔開):");
            enter = Console.ReadLine().Split(' ');
            ye = int.Parse(enter[0]);
            me = int.Parse(enter[1]);
            de = int.Parse(enter[2]);
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
