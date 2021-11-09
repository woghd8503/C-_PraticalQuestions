using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int days = 1;
            int money = 1000;

            while (true)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {2,11:C}", days, money, sum);
                if (sum >= 1000000)
                    break;
                days++;
                money += 2;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);
            if (sum >= 1000000)
                break;
            days++;
            money += 2;
        }
        Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);

            for(sum = 0; days=1, money=1000; ; days++, money += 2)
            {
                sum += money;
                Console.Write("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);
                if (sum >= 1000000)
                break;
            }
    }
}


